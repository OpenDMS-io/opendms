//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class JobProjectCrud {
		///<summary>Gets one JobProject object from the database using the primary key.  Returns null if not found.</summary>
		public static JobProject SelectOne(long jobProjectNum) {
			string command="SELECT * FROM jobproject "
				+"WHERE JobProjectNum = "+POut.Long(jobProjectNum);
			List<JobProject> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one JobProject object from the database using a query.</summary>
		public static JobProject SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<JobProject> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of JobProject objects from the database using a query.</summary>
		public static List<JobProject> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<JobProject> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<JobProject> TableToList(DataTable table) {
			List<JobProject> retVal=new List<JobProject>();
			JobProject jobProject;
			foreach(DataRow row in table.Rows) {
				jobProject=new JobProject();
				jobProject.JobProjectNum   = PIn.Long  (row["JobProjectNum"].ToString());
				jobProject.RootProjectNum  = PIn.Long  (row["RootProjectNum"].ToString());
				jobProject.ParentProjectNum= PIn.Long  (row["ParentProjectNum"].ToString());
				jobProject.Title           = PIn.String(row["Title"].ToString());
				jobProject.Description     = PIn.String(row["Description"].ToString());
				jobProject.ProjectStatus   = (OpenDentBusiness.JobProjectStatus)PIn.Int(row["ProjectStatus"].ToString());
				retVal.Add(jobProject);
			}
			return retVal;
		}

		///<summary>Converts a list of JobProject into a DataTable.</summary>
		public static DataTable ListToTable(List<JobProject> listJobProjects,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="JobProject";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("JobProjectNum");
			table.Columns.Add("RootProjectNum");
			table.Columns.Add("ParentProjectNum");
			table.Columns.Add("Title");
			table.Columns.Add("Description");
			table.Columns.Add("ProjectStatus");
			foreach(JobProject jobProject in listJobProjects) {
				table.Rows.Add(new object[] {
					POut.Long  (jobProject.JobProjectNum),
					POut.Long  (jobProject.RootProjectNum),
					POut.Long  (jobProject.ParentProjectNum),
					            jobProject.Title,
					            jobProject.Description,
					POut.Int   ((int)jobProject.ProjectStatus),
				});
			}
			return table;
		}

		///<summary>Inserts one JobProject into the database.  Returns the new priKey.</summary>
		public static long Insert(JobProject jobProject) {
			return Insert(jobProject,false);
		}

		///<summary>Inserts one JobProject into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(JobProject jobProject,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				jobProject.JobProjectNum=ReplicationServers.GetKey("jobproject","JobProjectNum");
			}
			string command="INSERT INTO jobproject (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="JobProjectNum,";
			}
			command+="RootProjectNum,ParentProjectNum,Title,Description,ProjectStatus) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(jobProject.JobProjectNum)+",";
			}
			command+=
				     POut.Long  (jobProject.RootProjectNum)+","
				+    POut.Long  (jobProject.ParentProjectNum)+","
				+"'"+POut.String(jobProject.Title)+"',"
				+"'"+POut.String(jobProject.Description)+"',"
				+    POut.Int   ((int)jobProject.ProjectStatus)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				jobProject.JobProjectNum=Db.NonQ(command,true,"JobProjectNum","jobProject");
			}
			return jobProject.JobProjectNum;
		}

		///<summary>Inserts one JobProject into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(JobProject jobProject) {
			return InsertNoCache(jobProject,false);
		}

		///<summary>Inserts one JobProject into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(JobProject jobProject,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO jobproject (";
			if(!useExistingPK && isRandomKeys) {
				jobProject.JobProjectNum=ReplicationServers.GetKeyNoCache("jobproject","JobProjectNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="JobProjectNum,";
			}
			command+="RootProjectNum,ParentProjectNum,Title,Description,ProjectStatus) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(jobProject.JobProjectNum)+",";
			}
			command+=
				     POut.Long  (jobProject.RootProjectNum)+","
				+    POut.Long  (jobProject.ParentProjectNum)+","
				+"'"+POut.String(jobProject.Title)+"',"
				+"'"+POut.String(jobProject.Description)+"',"
				+    POut.Int   ((int)jobProject.ProjectStatus)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				jobProject.JobProjectNum=Db.NonQ(command,true,"JobProjectNum","jobProject");
			}
			return jobProject.JobProjectNum;
		}

		///<summary>Updates one JobProject in the database.</summary>
		public static void Update(JobProject jobProject) {
			string command="UPDATE jobproject SET "
				+"RootProjectNum  =  "+POut.Long  (jobProject.RootProjectNum)+", "
				+"ParentProjectNum=  "+POut.Long  (jobProject.ParentProjectNum)+", "
				+"Title           = '"+POut.String(jobProject.Title)+"', "
				+"Description     = '"+POut.String(jobProject.Description)+"', "
				+"ProjectStatus   =  "+POut.Int   ((int)jobProject.ProjectStatus)+" "
				+"WHERE JobProjectNum = "+POut.Long(jobProject.JobProjectNum);
			Db.NonQ(command);
		}

		///<summary>Updates one JobProject in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(JobProject jobProject,JobProject oldJobProject) {
			string command="";
			if(jobProject.RootProjectNum != oldJobProject.RootProjectNum) {
				if(command!="") { command+=",";}
				command+="RootProjectNum = "+POut.Long(jobProject.RootProjectNum)+"";
			}
			if(jobProject.ParentProjectNum != oldJobProject.ParentProjectNum) {
				if(command!="") { command+=",";}
				command+="ParentProjectNum = "+POut.Long(jobProject.ParentProjectNum)+"";
			}
			if(jobProject.Title != oldJobProject.Title) {
				if(command!="") { command+=",";}
				command+="Title = '"+POut.String(jobProject.Title)+"'";
			}
			if(jobProject.Description != oldJobProject.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(jobProject.Description)+"'";
			}
			if(jobProject.ProjectStatus != oldJobProject.ProjectStatus) {
				if(command!="") { command+=",";}
				command+="ProjectStatus = "+POut.Int   ((int)jobProject.ProjectStatus)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE jobproject SET "+command
				+" WHERE JobProjectNum = "+POut.Long(jobProject.JobProjectNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(JobProject,JobProject) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(JobProject jobProject,JobProject oldJobProject) {
			if(jobProject.RootProjectNum != oldJobProject.RootProjectNum) {
				return true;
			}
			if(jobProject.ParentProjectNum != oldJobProject.ParentProjectNum) {
				return true;
			}
			if(jobProject.Title != oldJobProject.Title) {
				return true;
			}
			if(jobProject.Description != oldJobProject.Description) {
				return true;
			}
			if(jobProject.ProjectStatus != oldJobProject.ProjectStatus) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one JobProject from the database.</summary>
		public static void Delete(long jobProjectNum) {
			string command="DELETE FROM jobproject "
				+"WHERE JobProjectNum = "+POut.Long(jobProjectNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many JobProjects from the database.</summary>
		public static void DeleteMany(List<long> listJobProjectNums) {
			if(listJobProjectNums==null || listJobProjectNums.Count==0) {
				return;
			}
			string command="DELETE FROM jobproject "
				+"WHERE JobProjectNum IN("+string.Join(",",listJobProjectNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}