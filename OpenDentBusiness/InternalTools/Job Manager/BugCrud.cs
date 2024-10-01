//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class BugCrud {
		///<summary>Gets one Bug object from the database using the primary key.  Returns null if not found.</summary>
		public static Bug SelectOne(long bugId) {
			string command="SELECT * FROM bug "
				+"WHERE BugId = "+POut.Long(bugId);
			List<Bug> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Bug object from the database using a query.</summary>
		public static Bug SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Bug> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Bug objects from the database using a query.</summary>
		public static List<Bug> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Bug> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Bug> TableToList(DataTable table) {
			List<Bug> retVal=new List<Bug>();
			Bug bug;
			foreach(DataRow row in table.Rows) {
				bug=new Bug();
				bug.BugId        = PIn.Long  (row["BugId"].ToString());
				bug.CreationDate = PIn.DateT (row["CreationDate"].ToString());
				bug.Status_      = (BugStatus)Enum.Parse(typeof(OpenDentBusiness.BugStatus),row["Status_"].ToString());
				bug.Type_        = (BugType)Enum.Parse(typeof(OpenDentBusiness.BugType),row["Type_"].ToString());
				bug.PriorityLevel= PIn.Int   (row["PriorityLevel"].ToString());
				bug.VersionsFound= PIn.String(row["VersionsFound"].ToString());
				bug.VersionsFixed= PIn.String(row["VersionsFixed"].ToString());
				bug.Description  = PIn.String(row["Description"].ToString());
				bug.LongDesc     = PIn.String(row["LongDesc"].ToString());
				bug.PrivateDesc  = PIn.String(row["PrivateDesc"].ToString());
				bug.Discussion   = PIn.String(row["Discussion"].ToString());
				bug.Submitter    = PIn.Long  (row["Submitter"].ToString());
				retVal.Add(bug);
			}
			return retVal;
		}

		///<summary>Converts a list of Bug into a DataTable.</summary>
		public static DataTable ListToTable(List<Bug> listBugs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Bug";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("BugId");
			table.Columns.Add("CreationDate");
			table.Columns.Add("Status_");
			table.Columns.Add("Type_");
			table.Columns.Add("PriorityLevel");
			table.Columns.Add("VersionsFound");
			table.Columns.Add("VersionsFixed");
			table.Columns.Add("Description");
			table.Columns.Add("LongDesc");
			table.Columns.Add("PrivateDesc");
			table.Columns.Add("Discussion");
			table.Columns.Add("Submitter");
			foreach(Bug bug in listBugs) {
				table.Rows.Add(new object[] {
					POut.Long  (bug.BugId),
					POut.DateT (bug.CreationDate,false),
											bug.Status_,
											bug.Type_,
					POut.Int   (bug.PriorityLevel),
					            bug.VersionsFound,
					            bug.VersionsFixed,
					            bug.Description,
					            bug.LongDesc,
					            bug.PrivateDesc,
					            bug.Discussion,
					POut.Long  (bug.Submitter),
				});
			}
			return table;
		}

		///<summary>Inserts one Bug into the database.  Returns the new priKey.</summary>
		public static long Insert(Bug bug) {
			return Insert(bug,false);
		}

		///<summary>Inserts one Bug into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Bug bug,bool useExistingPK) {
			string command="INSERT INTO bug (";
			if(useExistingPK) {
				command+="BugId,";
			}
			command+="CreationDate,Status_,Type_,PriorityLevel,VersionsFound,VersionsFixed,Description,LongDesc,PrivateDesc,Discussion,Submitter) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(bug.BugId)+",";
			}
			command+=
				     POut.DateT (bug.CreationDate)+","
				+"'"+POut.String(bug.Status_.ToString())+"', "
				+"'"+POut.String(bug.Type_.ToString())+"', "
				+    POut.Int   (bug.PriorityLevel)+","
				+"'"+POut.String(bug.VersionsFound)+"',"
				+"'"+POut.String(bug.VersionsFixed)+"',"
				+"'"+POut.String(bug.Description)+"',"
				+"'"+POut.String(bug.LongDesc)+"',"
				+"'"+POut.String(bug.PrivateDesc)+"',"
				+"'"+POut.String(bug.Discussion)+"',"
				+    POut.Long  (bug.Submitter)+")";
			if(useExistingPK) {
				Db.NonQ(command);
			}
			else {
				bug.BugId=Db.NonQ(command,true,"BugId","bug");
			}
			return bug.BugId;
		}

		///<summary>Inserts one Bug into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Bug bug) {
			return InsertNoCache(bug,false);
		}

		///<summary>Inserts one Bug into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Bug bug,bool useExistingPK) {
			string command="INSERT INTO bug (";
			if(useExistingPK) {
				command+="BugId,";
			}
			command+="CreationDate,Status_,Type_,PriorityLevel,VersionsFound,VersionsFixed,Description,LongDesc,PrivateDesc,Discussion,Submitter) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(bug.BugId)+",";
			}
			command+=
				     POut.DateT (bug.CreationDate)+","
				+"'"+POut.String(bug.Status_.ToString())+"', "
				+"'"+POut.String(bug.Type_.ToString())+"', "
				+    POut.Int   (bug.PriorityLevel)+","
				+"'"+POut.String(bug.VersionsFound)+"',"
				+"'"+POut.String(bug.VersionsFixed)+"',"
				+"'"+POut.String(bug.Description)+"',"
				+"'"+POut.String(bug.LongDesc)+"',"
				+"'"+POut.String(bug.PrivateDesc)+"',"
				+"'"+POut.String(bug.Discussion)+"',"
				+    POut.Long  (bug.Submitter)+")";
			if(useExistingPK) {
				Db.NonQ(command);
			}
			else {
				bug.BugId=Db.NonQ(command,true,"BugId","bug");
			}
			return bug.BugId;
		}

		///<summary>Updates one Bug in the database.</summary>
		public static void Update(Bug bug) {
			string command="UPDATE bug SET "
				+"CreationDate =  "+POut.DateT (bug.CreationDate)+", "
				+"Status_      = '"+POut.String(bug.Status_.ToString())+"', "
				+"Type_        = '"+POut.String(bug.Type_.ToString())+"', "
				+"PriorityLevel=  "+POut.Int   (bug.PriorityLevel)+", "
				+"VersionsFound= '"+POut.String(bug.VersionsFound)+"', "
				+"VersionsFixed= '"+POut.String(bug.VersionsFixed)+"', "
				+"Description  = '"+POut.String(bug.Description)+"', "
				+"LongDesc     = '"+POut.String(bug.LongDesc)+"', "
				+"PrivateDesc  = '"+POut.String(bug.PrivateDesc)+"', "
				+"Discussion   = '"+POut.String(bug.Discussion)+"', "
				+"Submitter    =  "+POut.Long  (bug.Submitter)+" "
				+"WHERE BugId = "+POut.Long(bug.BugId);
			Db.NonQ(command);
		}

		///<summary>Updates one Bug in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Bug bug,Bug oldBug) {
			string command="";
			if(bug.CreationDate != oldBug.CreationDate) {
				if(command!="") { command+=",";}
				command+="CreationDate = "+POut.DateT(bug.CreationDate)+"";
			}
			if(bug.Status_ != oldBug.Status_) {
				if(command!="") { command+=",";}
				command+="Status_ = '"+POut.String   (bug.Status_.ToString())+"'";
			}
			if(bug.Type_ != oldBug.Type_) {
				if(command!="") { command+=",";}
				command+="Type_ = '"+POut.String   (bug.Type_.ToString())+"'";
			}
			if(bug.PriorityLevel != oldBug.PriorityLevel) {
				if(command!="") { command+=",";}
				command+="PriorityLevel = "+POut.Int(bug.PriorityLevel)+"";
			}
			if(bug.VersionsFound != oldBug.VersionsFound) {
				if(command!="") { command+=",";}
				command+="VersionsFound = '"+POut.String(bug.VersionsFound)+"'";
			}
			if(bug.VersionsFixed != oldBug.VersionsFixed) {
				if(command!="") { command+=",";}
				command+="VersionsFixed = '"+POut.String(bug.VersionsFixed)+"'";
			}
			if(bug.Description != oldBug.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(bug.Description)+"'";
			}
			if(bug.LongDesc != oldBug.LongDesc) {
				if(command!="") { command+=",";}
				command+="LongDesc = '"+POut.String(bug.LongDesc)+"'";
			}
			if(bug.PrivateDesc != oldBug.PrivateDesc) {
				if(command!="") { command+=",";}
				command+="PrivateDesc = '"+POut.String(bug.PrivateDesc)+"'";
			}
			if(bug.Discussion != oldBug.Discussion) {
				if(command!="") { command+=",";}
				command+="Discussion = '"+POut.String(bug.Discussion)+"'";
			}
			if(bug.Submitter != oldBug.Submitter) {
				if(command!="") { command+=",";}
				command+="Submitter = "+POut.Long(bug.Submitter)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE bug SET "+command
				+" WHERE BugId = "+POut.Long(bug.BugId);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Bug,Bug) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Bug bug,Bug oldBug) {
			if(bug.CreationDate != oldBug.CreationDate) {
				return true;
			}
			if(bug.Status_ != oldBug.Status_) {
				return true;
			}
			if(bug.Type_ != oldBug.Type_) {
				return true;
			}
			if(bug.PriorityLevel != oldBug.PriorityLevel) {
				return true;
			}
			if(bug.VersionsFound != oldBug.VersionsFound) {
				return true;
			}
			if(bug.VersionsFixed != oldBug.VersionsFixed) {
				return true;
			}
			if(bug.Description != oldBug.Description) {
				return true;
			}
			if(bug.LongDesc != oldBug.LongDesc) {
				return true;
			}
			if(bug.PrivateDesc != oldBug.PrivateDesc) {
				return true;
			}
			if(bug.Discussion != oldBug.Discussion) {
				return true;
			}
			if(bug.Submitter != oldBug.Submitter) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Bug from the database.</summary>
		public static void Delete(long bugId) {
			string command="DELETE FROM bug "
				+"WHERE BugId = "+POut.Long(bugId);
			Db.NonQ(command);
		}

	}
}