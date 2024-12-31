//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class AppointmentCrud {
		///<summary>Gets one Appointment object from the database using the primary key.  Returns null if not found.</summary>
		public static Appointment SelectOne(long aptNum) {
			string command="SELECT * FROM appointment "
				+"WHERE AptNum = "+POut.Long(aptNum);
			List<Appointment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Appointment object from the database using a query.</summary>
		public static Appointment SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Appointment> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Appointment objects from the database using a query.</summary>
		public static List<Appointment> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Appointment> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Appointment> TableToList(DataTable table) {
			List<Appointment> retVal=new List<Appointment>();
			Appointment appointment;
			foreach(DataRow row in table.Rows) {
				appointment=new Appointment();
				appointment.AptNum               = PIn.Long  (row["AptNum"].ToString());
				appointment.PatNum               = PIn.Long  (row["PatNum"].ToString());
				appointment.AptStatus            = (OpenDentBusiness.ApptStatus)PIn.Int(row["AptStatus"].ToString());
				appointment.Pattern              = PIn.String(row["Pattern"].ToString());
				appointment.Confirmed            = PIn.Long  (row["Confirmed"].ToString());
				appointment.TimeLocked           = PIn.Bool  (row["TimeLocked"].ToString());
				appointment.Op                   = PIn.Long  (row["Op"].ToString());
				appointment.Note                 = PIn.String(row["Note"].ToString());
				appointment.ProvNum              = PIn.Long  (row["ProvNum"].ToString());
				appointment.ProvHyg              = PIn.Long  (row["ProvHyg"].ToString());
				appointment.AptDateTime          = PIn.DateT (row["AptDateTime"].ToString());
				appointment.NextAptNum           = PIn.Long  (row["NextAptNum"].ToString());
				appointment.UnschedStatus        = PIn.Long  (row["UnschedStatus"].ToString());
				appointment.IsNewPatient         = PIn.Bool  (row["IsNewPatient"].ToString());
				appointment.ProcDescript         = PIn.String(row["ProcDescript"].ToString());
				appointment.Assistant            = PIn.Long  (row["Assistant"].ToString());
				appointment.ClinicNum            = PIn.Long  (row["ClinicNum"].ToString());
				appointment.IsHygiene            = PIn.Bool  (row["IsHygiene"].ToString());
				appointment.DateTStamp           = PIn.DateT (row["DateTStamp"].ToString());
				appointment.DateTimeArrived      = PIn.DateT (row["DateTimeArrived"].ToString());
				appointment.DateTimeSeated       = PIn.DateT (row["DateTimeSeated"].ToString());
				appointment.DateTimeDismissed    = PIn.DateT (row["DateTimeDismissed"].ToString());
				appointment.InsPlan1             = PIn.Long  (row["InsPlan1"].ToString());
				appointment.InsPlan2             = PIn.Long  (row["InsPlan2"].ToString());
				appointment.DateTimeAskedToArrive= PIn.DateT (row["DateTimeAskedToArrive"].ToString());
				appointment.ProcsColored         = PIn.String(row["ProcsColored"].ToString());
				appointment.ColorOverride        = Color.FromArgb(PIn.Int(row["ColorOverride"].ToString()));
				appointment.AppointmentTypeNum   = PIn.Long  (row["AppointmentTypeNum"].ToString());
				appointment.SecUserNumEntry      = PIn.Long  (row["SecUserNumEntry"].ToString());
				appointment.SecDateTEntry        = PIn.DateT (row["SecDateTEntry"].ToString());
				appointment.Priority             = (OpenDentBusiness.ApptPriority)PIn.Int(row["Priority"].ToString());
				appointment.ProvBarText          = PIn.String(row["ProvBarText"].ToString());
				appointment.PatternSecondary     = PIn.String(row["PatternSecondary"].ToString());
				appointment.SecurityHash         = PIn.String(row["SecurityHash"].ToString());
				appointment.ItemOrderPlanned     = PIn.Int   (row["ItemOrderPlanned"].ToString());
				retVal.Add(appointment);
			}
			return retVal;
		}

		///<summary>Converts a list of Appointment into a DataTable.</summary>
		public static DataTable ListToTable(List<Appointment> listAppointments,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Appointment";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("AptNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("AptStatus");
			table.Columns.Add("Pattern");
			table.Columns.Add("Confirmed");
			table.Columns.Add("TimeLocked");
			table.Columns.Add("Op");
			table.Columns.Add("Note");
			table.Columns.Add("ProvNum");
			table.Columns.Add("ProvHyg");
			table.Columns.Add("AptDateTime");
			table.Columns.Add("NextAptNum");
			table.Columns.Add("UnschedStatus");
			table.Columns.Add("IsNewPatient");
			table.Columns.Add("ProcDescript");
			table.Columns.Add("Assistant");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("IsHygiene");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("DateTimeArrived");
			table.Columns.Add("DateTimeSeated");
			table.Columns.Add("DateTimeDismissed");
			table.Columns.Add("InsPlan1");
			table.Columns.Add("InsPlan2");
			table.Columns.Add("DateTimeAskedToArrive");
			table.Columns.Add("ProcsColored");
			table.Columns.Add("ColorOverride");
			table.Columns.Add("AppointmentTypeNum");
			table.Columns.Add("SecUserNumEntry");
			table.Columns.Add("SecDateTEntry");
			table.Columns.Add("Priority");
			table.Columns.Add("ProvBarText");
			table.Columns.Add("PatternSecondary");
			table.Columns.Add("SecurityHash");
			table.Columns.Add("ItemOrderPlanned");
			foreach(Appointment appointment in listAppointments) {
				table.Rows.Add(new object[] {
					POut.Long  (appointment.AptNum),
					POut.Long  (appointment.PatNum),
					POut.Int   ((int)appointment.AptStatus),
					            appointment.Pattern,
					POut.Long  (appointment.Confirmed),
					POut.Bool  (appointment.TimeLocked),
					POut.Long  (appointment.Op),
					            appointment.Note,
					POut.Long  (appointment.ProvNum),
					POut.Long  (appointment.ProvHyg),
					POut.DateT (appointment.AptDateTime,false),
					POut.Long  (appointment.NextAptNum),
					POut.Long  (appointment.UnschedStatus),
					POut.Bool  (appointment.IsNewPatient),
					            appointment.ProcDescript,
					POut.Long  (appointment.Assistant),
					POut.Long  (appointment.ClinicNum),
					POut.Bool  (appointment.IsHygiene),
					POut.DateT (appointment.DateTStamp,false),
					POut.DateT (appointment.DateTimeArrived,false),
					POut.DateT (appointment.DateTimeSeated,false),
					POut.DateT (appointment.DateTimeDismissed,false),
					POut.Long  (appointment.InsPlan1),
					POut.Long  (appointment.InsPlan2),
					POut.DateT (appointment.DateTimeAskedToArrive,false),
					            appointment.ProcsColored,
					POut.Int   (appointment.ColorOverride.ToArgb()),
					POut.Long  (appointment.AppointmentTypeNum),
					POut.Long  (appointment.SecUserNumEntry),
					POut.DateT (appointment.SecDateTEntry,false),
					POut.Int   ((int)appointment.Priority),
					            appointment.ProvBarText,
					            appointment.PatternSecondary,
					            appointment.SecurityHash,
					POut.Int   (appointment.ItemOrderPlanned),
				});
			}
			return table;
		}

		///<summary>Inserts one Appointment into the database.  Returns the new priKey.</summary>
		public static long Insert(Appointment appointment) {
			return Insert(appointment,false);
		}

		///<summary>Inserts one Appointment into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Appointment appointment,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				appointment.AptNum=ReplicationServers.GetKey("appointment","AptNum");
			}
			string command="INSERT INTO appointment (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="AptNum,";
			}
			command+="PatNum,AptStatus,Pattern,Confirmed,TimeLocked,Op,Note,ProvNum,ProvHyg,AptDateTime,NextAptNum,UnschedStatus,IsNewPatient,ProcDescript,Assistant,ClinicNum,IsHygiene,DateTimeArrived,DateTimeSeated,DateTimeDismissed,InsPlan1,InsPlan2,DateTimeAskedToArrive,ProcsColored,ColorOverride,AppointmentTypeNum,SecUserNumEntry,SecDateTEntry,Priority,ProvBarText,PatternSecondary,SecurityHash,ItemOrderPlanned) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(appointment.AptNum)+",";
			}
			command+=
				     POut.Long  (appointment.PatNum)+","
				+    POut.Int   ((int)appointment.AptStatus)+","
				+"'"+POut.String(appointment.Pattern)+"',"
				+    POut.Long  (appointment.Confirmed)+","
				+    POut.Bool  (appointment.TimeLocked)+","
				+    POut.Long  (appointment.Op)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    POut.Long  (appointment.ProvNum)+","
				+    POut.Long  (appointment.ProvHyg)+","
				+    POut.DateT (appointment.AptDateTime)+","
				+    POut.Long  (appointment.NextAptNum)+","
				+    POut.Long  (appointment.UnschedStatus)+","
				+    POut.Bool  (appointment.IsNewPatient)+","
				+    DbHelper.ParamChar+"paramProcDescript,"
				+    POut.Long  (appointment.Assistant)+","
				+    POut.Long  (appointment.ClinicNum)+","
				+    POut.Bool  (appointment.IsHygiene)+","
				//DateTStamp can only be set by MySQL
				+    POut.DateT (appointment.DateTimeArrived)+","
				+    POut.DateT (appointment.DateTimeSeated)+","
				+    POut.DateT (appointment.DateTimeDismissed)+","
				+    POut.Long  (appointment.InsPlan1)+","
				+    POut.Long  (appointment.InsPlan2)+","
				+    POut.DateT (appointment.DateTimeAskedToArrive)+","
				+    DbHelper.ParamChar+"paramProcsColored,"
				+    POut.Int   (appointment.ColorOverride.ToArgb())+","
				+    POut.Long  (appointment.AppointmentTypeNum)+","
				+    POut.Long  (appointment.SecUserNumEntry)+","
				+    DbHelper.Now()+","
				+    POut.Int   ((int)appointment.Priority)+","
				+"'"+POut.String(appointment.ProvBarText)+"',"
				+"'"+POut.String(appointment.PatternSecondary)+"',"
				+"'"+POut.String(appointment.SecurityHash)+"',"
				+    POut.Int   (appointment.ItemOrderPlanned)+")";
			if(appointment.Note==null) {
				appointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(appointment.Note));
			if(appointment.ProcDescript==null) {
				appointment.ProcDescript="";
			}
			OdSqlParameter paramProcDescript=new OdSqlParameter("paramProcDescript",OdDbType.Text,POut.StringParam(appointment.ProcDescript));
			if(appointment.ProcsColored==null) {
				appointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(appointment.ProcsColored));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramNote,paramProcDescript,paramProcsColored);
			}
			else {
				appointment.AptNum=Db.NonQ(command,true,"AptNum","appointment",paramNote,paramProcDescript,paramProcsColored);
			}
			return appointment.AptNum;
		}

		///<summary>Inserts one Appointment into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Appointment appointment) {
			return InsertNoCache(appointment,false);
		}

		///<summary>Inserts one Appointment into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Appointment appointment,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO appointment (";
			if(!useExistingPK && isRandomKeys) {
				appointment.AptNum=ReplicationServers.GetKeyNoCache("appointment","AptNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="AptNum,";
			}
			command+="PatNum,AptStatus,Pattern,Confirmed,TimeLocked,Op,Note,ProvNum,ProvHyg,AptDateTime,NextAptNum,UnschedStatus,IsNewPatient,ProcDescript,Assistant,ClinicNum,IsHygiene,DateTimeArrived,DateTimeSeated,DateTimeDismissed,InsPlan1,InsPlan2,DateTimeAskedToArrive,ProcsColored,ColorOverride,AppointmentTypeNum,SecUserNumEntry,SecDateTEntry,Priority,ProvBarText,PatternSecondary,SecurityHash,ItemOrderPlanned) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(appointment.AptNum)+",";
			}
			command+=
				     POut.Long  (appointment.PatNum)+","
				+    POut.Int   ((int)appointment.AptStatus)+","
				+"'"+POut.String(appointment.Pattern)+"',"
				+    POut.Long  (appointment.Confirmed)+","
				+    POut.Bool  (appointment.TimeLocked)+","
				+    POut.Long  (appointment.Op)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    POut.Long  (appointment.ProvNum)+","
				+    POut.Long  (appointment.ProvHyg)+","
				+    POut.DateT (appointment.AptDateTime)+","
				+    POut.Long  (appointment.NextAptNum)+","
				+    POut.Long  (appointment.UnschedStatus)+","
				+    POut.Bool  (appointment.IsNewPatient)+","
				+    DbHelper.ParamChar+"paramProcDescript,"
				+    POut.Long  (appointment.Assistant)+","
				+    POut.Long  (appointment.ClinicNum)+","
				+    POut.Bool  (appointment.IsHygiene)+","
				//DateTStamp can only be set by MySQL
				+    POut.DateT (appointment.DateTimeArrived)+","
				+    POut.DateT (appointment.DateTimeSeated)+","
				+    POut.DateT (appointment.DateTimeDismissed)+","
				+    POut.Long  (appointment.InsPlan1)+","
				+    POut.Long  (appointment.InsPlan2)+","
				+    POut.DateT (appointment.DateTimeAskedToArrive)+","
				+    DbHelper.ParamChar+"paramProcsColored,"
				+    POut.Int   (appointment.ColorOverride.ToArgb())+","
				+    POut.Long  (appointment.AppointmentTypeNum)+","
				+    POut.Long  (appointment.SecUserNumEntry)+","
				+    DbHelper.Now()+","
				+    POut.Int   ((int)appointment.Priority)+","
				+"'"+POut.String(appointment.ProvBarText)+"',"
				+"'"+POut.String(appointment.PatternSecondary)+"',"
				+"'"+POut.String(appointment.SecurityHash)+"',"
				+    POut.Int   (appointment.ItemOrderPlanned)+")";
			if(appointment.Note==null) {
				appointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(appointment.Note));
			if(appointment.ProcDescript==null) {
				appointment.ProcDescript="";
			}
			OdSqlParameter paramProcDescript=new OdSqlParameter("paramProcDescript",OdDbType.Text,POut.StringParam(appointment.ProcDescript));
			if(appointment.ProcsColored==null) {
				appointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(appointment.ProcsColored));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramNote,paramProcDescript,paramProcsColored);
			}
			else {
				appointment.AptNum=Db.NonQ(command,true,"AptNum","appointment",paramNote,paramProcDescript,paramProcsColored);
			}
			return appointment.AptNum;
		}

		///<summary>Updates one Appointment in the database.</summary>
		public static void Update(Appointment appointment) {
			string command="UPDATE appointment SET "
				+"PatNum               =  "+POut.Long  (appointment.PatNum)+", "
				+"AptStatus            =  "+POut.Int   ((int)appointment.AptStatus)+", "
				+"Pattern              = '"+POut.String(appointment.Pattern)+"', "
				+"Confirmed            =  "+POut.Long  (appointment.Confirmed)+", "
				+"TimeLocked           =  "+POut.Bool  (appointment.TimeLocked)+", "
				+"Op                   =  "+POut.Long  (appointment.Op)+", "
				+"Note                 =  "+DbHelper.ParamChar+"paramNote, "
				+"ProvNum              =  "+POut.Long  (appointment.ProvNum)+", "
				+"ProvHyg              =  "+POut.Long  (appointment.ProvHyg)+", "
				+"AptDateTime          =  "+POut.DateT (appointment.AptDateTime)+", "
				+"NextAptNum           =  "+POut.Long  (appointment.NextAptNum)+", "
				+"UnschedStatus        =  "+POut.Long  (appointment.UnschedStatus)+", "
				+"IsNewPatient         =  "+POut.Bool  (appointment.IsNewPatient)+", "
				+"ProcDescript         =  "+DbHelper.ParamChar+"paramProcDescript, "
				+"Assistant            =  "+POut.Long  (appointment.Assistant)+", "
				+"ClinicNum            =  "+POut.Long  (appointment.ClinicNum)+", "
				+"IsHygiene            =  "+POut.Bool  (appointment.IsHygiene)+", "
				//DateTStamp can only be set by MySQL
				+"DateTimeArrived      =  "+POut.DateT (appointment.DateTimeArrived)+", "
				+"DateTimeSeated       =  "+POut.DateT (appointment.DateTimeSeated)+", "
				+"DateTimeDismissed    =  "+POut.DateT (appointment.DateTimeDismissed)+", "
				+"InsPlan1             =  "+POut.Long  (appointment.InsPlan1)+", "
				+"InsPlan2             =  "+POut.Long  (appointment.InsPlan2)+", "
				+"DateTimeAskedToArrive=  "+POut.DateT (appointment.DateTimeAskedToArrive)+", "
				+"ProcsColored         =  "+DbHelper.ParamChar+"paramProcsColored, "
				+"ColorOverride        =  "+POut.Int   (appointment.ColorOverride.ToArgb())+", "
				+"AppointmentTypeNum   =  "+POut.Long  (appointment.AppointmentTypeNum)+", "
				//SecUserNumEntry excluded from update
				//SecDateTEntry not allowed to change
				+"Priority             =  "+POut.Int   ((int)appointment.Priority)+", "
				+"ProvBarText          = '"+POut.String(appointment.ProvBarText)+"', "
				+"PatternSecondary     = '"+POut.String(appointment.PatternSecondary)+"', "
				+"SecurityHash         = '"+POut.String(appointment.SecurityHash)+"', "
				+"ItemOrderPlanned     =  "+POut.Int   (appointment.ItemOrderPlanned)+" "
				+"WHERE AptNum = "+POut.Long(appointment.AptNum);
			if(appointment.Note==null) {
				appointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(appointment.Note));
			if(appointment.ProcDescript==null) {
				appointment.ProcDescript="";
			}
			OdSqlParameter paramProcDescript=new OdSqlParameter("paramProcDescript",OdDbType.Text,POut.StringParam(appointment.ProcDescript));
			if(appointment.ProcsColored==null) {
				appointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(appointment.ProcsColored));
			Db.NonQ(command,paramNote,paramProcDescript,paramProcsColored);
		}

		///<summary>Updates one Appointment in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Appointment appointment,Appointment oldAppointment) {
			string command="";
			if(appointment.PatNum != oldAppointment.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(appointment.PatNum)+"";
			}
			if(appointment.AptStatus != oldAppointment.AptStatus) {
				if(command!="") { command+=",";}
				command+="AptStatus = "+POut.Int   ((int)appointment.AptStatus)+"";
			}
			if(appointment.Pattern != oldAppointment.Pattern) {
				if(command!="") { command+=",";}
				command+="Pattern = '"+POut.String(appointment.Pattern)+"'";
			}
			if(appointment.Confirmed != oldAppointment.Confirmed) {
				if(command!="") { command+=",";}
				command+="Confirmed = "+POut.Long(appointment.Confirmed)+"";
			}
			if(appointment.TimeLocked != oldAppointment.TimeLocked) {
				if(command!="") { command+=",";}
				command+="TimeLocked = "+POut.Bool(appointment.TimeLocked)+"";
			}
			if(appointment.Op != oldAppointment.Op) {
				if(command!="") { command+=",";}
				command+="Op = "+POut.Long(appointment.Op)+"";
			}
			if(appointment.Note != oldAppointment.Note) {
				if(command!="") { command+=",";}
				command+="Note = "+DbHelper.ParamChar+"paramNote";
			}
			if(appointment.ProvNum != oldAppointment.ProvNum) {
				if(command!="") { command+=",";}
				command+="ProvNum = "+POut.Long(appointment.ProvNum)+"";
			}
			if(appointment.ProvHyg != oldAppointment.ProvHyg) {
				if(command!="") { command+=",";}
				command+="ProvHyg = "+POut.Long(appointment.ProvHyg)+"";
			}
			if(appointment.AptDateTime != oldAppointment.AptDateTime) {
				if(command!="") { command+=",";}
				command+="AptDateTime = "+POut.DateT(appointment.AptDateTime)+"";
			}
			if(appointment.NextAptNum != oldAppointment.NextAptNum) {
				if(command!="") { command+=",";}
				command+="NextAptNum = "+POut.Long(appointment.NextAptNum)+"";
			}
			if(appointment.UnschedStatus != oldAppointment.UnschedStatus) {
				if(command!="") { command+=",";}
				command+="UnschedStatus = "+POut.Long(appointment.UnschedStatus)+"";
			}
			if(appointment.IsNewPatient != oldAppointment.IsNewPatient) {
				if(command!="") { command+=",";}
				command+="IsNewPatient = "+POut.Bool(appointment.IsNewPatient)+"";
			}
			if(appointment.ProcDescript != oldAppointment.ProcDescript) {
				if(command!="") { command+=",";}
				command+="ProcDescript = "+DbHelper.ParamChar+"paramProcDescript";
			}
			if(appointment.Assistant != oldAppointment.Assistant) {
				if(command!="") { command+=",";}
				command+="Assistant = "+POut.Long(appointment.Assistant)+"";
			}
			if(appointment.ClinicNum != oldAppointment.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(appointment.ClinicNum)+"";
			}
			if(appointment.IsHygiene != oldAppointment.IsHygiene) {
				if(command!="") { command+=",";}
				command+="IsHygiene = "+POut.Bool(appointment.IsHygiene)+"";
			}
			//DateTStamp can only be set by MySQL
			if(appointment.DateTimeArrived != oldAppointment.DateTimeArrived) {
				if(command!="") { command+=",";}
				command+="DateTimeArrived = "+POut.DateT(appointment.DateTimeArrived)+"";
			}
			if(appointment.DateTimeSeated != oldAppointment.DateTimeSeated) {
				if(command!="") { command+=",";}
				command+="DateTimeSeated = "+POut.DateT(appointment.DateTimeSeated)+"";
			}
			if(appointment.DateTimeDismissed != oldAppointment.DateTimeDismissed) {
				if(command!="") { command+=",";}
				command+="DateTimeDismissed = "+POut.DateT(appointment.DateTimeDismissed)+"";
			}
			if(appointment.InsPlan1 != oldAppointment.InsPlan1) {
				if(command!="") { command+=",";}
				command+="InsPlan1 = "+POut.Long(appointment.InsPlan1)+"";
			}
			if(appointment.InsPlan2 != oldAppointment.InsPlan2) {
				if(command!="") { command+=",";}
				command+="InsPlan2 = "+POut.Long(appointment.InsPlan2)+"";
			}
			if(appointment.DateTimeAskedToArrive != oldAppointment.DateTimeAskedToArrive) {
				if(command!="") { command+=",";}
				command+="DateTimeAskedToArrive = "+POut.DateT(appointment.DateTimeAskedToArrive)+"";
			}
			if(appointment.ProcsColored != oldAppointment.ProcsColored) {
				if(command!="") { command+=",";}
				command+="ProcsColored = "+DbHelper.ParamChar+"paramProcsColored";
			}
			if(appointment.ColorOverride != oldAppointment.ColorOverride) {
				if(command!="") { command+=",";}
				command+="ColorOverride = "+POut.Int(appointment.ColorOverride.ToArgb())+"";
			}
			if(appointment.AppointmentTypeNum != oldAppointment.AppointmentTypeNum) {
				if(command!="") { command+=",";}
				command+="AppointmentTypeNum = "+POut.Long(appointment.AppointmentTypeNum)+"";
			}
			//SecUserNumEntry excluded from update
			//SecDateTEntry not allowed to change
			if(appointment.Priority != oldAppointment.Priority) {
				if(command!="") { command+=",";}
				command+="Priority = "+POut.Int   ((int)appointment.Priority)+"";
			}
			if(appointment.ProvBarText != oldAppointment.ProvBarText) {
				if(command!="") { command+=",";}
				command+="ProvBarText = '"+POut.String(appointment.ProvBarText)+"'";
			}
			if(appointment.PatternSecondary != oldAppointment.PatternSecondary) {
				if(command!="") { command+=",";}
				command+="PatternSecondary = '"+POut.String(appointment.PatternSecondary)+"'";
			}
			if(appointment.SecurityHash != oldAppointment.SecurityHash) {
				if(command!="") { command+=",";}
				command+="SecurityHash = '"+POut.String(appointment.SecurityHash)+"'";
			}
			if(appointment.ItemOrderPlanned != oldAppointment.ItemOrderPlanned) {
				if(command!="") { command+=",";}
				command+="ItemOrderPlanned = "+POut.Int(appointment.ItemOrderPlanned)+"";
			}
			if(command=="") {
				return false;
			}
			if(appointment.Note==null) {
				appointment.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringNote(appointment.Note));
			if(appointment.ProcDescript==null) {
				appointment.ProcDescript="";
			}
			OdSqlParameter paramProcDescript=new OdSqlParameter("paramProcDescript",OdDbType.Text,POut.StringParam(appointment.ProcDescript));
			if(appointment.ProcsColored==null) {
				appointment.ProcsColored="";
			}
			OdSqlParameter paramProcsColored=new OdSqlParameter("paramProcsColored",OdDbType.Text,POut.StringParam(appointment.ProcsColored));
			command="UPDATE appointment SET "+command
				+" WHERE AptNum = "+POut.Long(appointment.AptNum);
			Db.NonQ(command,paramNote,paramProcDescript,paramProcsColored);
			return true;
		}

		///<summary>Returns true if Update(Appointment,Appointment) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Appointment appointment,Appointment oldAppointment) {
			if(appointment.PatNum != oldAppointment.PatNum) {
				return true;
			}
			if(appointment.AptStatus != oldAppointment.AptStatus) {
				return true;
			}
			if(appointment.Pattern != oldAppointment.Pattern) {
				return true;
			}
			if(appointment.Confirmed != oldAppointment.Confirmed) {
				return true;
			}
			if(appointment.TimeLocked != oldAppointment.TimeLocked) {
				return true;
			}
			if(appointment.Op != oldAppointment.Op) {
				return true;
			}
			if(appointment.Note != oldAppointment.Note) {
				return true;
			}
			if(appointment.ProvNum != oldAppointment.ProvNum) {
				return true;
			}
			if(appointment.ProvHyg != oldAppointment.ProvHyg) {
				return true;
			}
			if(appointment.AptDateTime != oldAppointment.AptDateTime) {
				return true;
			}
			if(appointment.NextAptNum != oldAppointment.NextAptNum) {
				return true;
			}
			if(appointment.UnschedStatus != oldAppointment.UnschedStatus) {
				return true;
			}
			if(appointment.IsNewPatient != oldAppointment.IsNewPatient) {
				return true;
			}
			if(appointment.ProcDescript != oldAppointment.ProcDescript) {
				return true;
			}
			if(appointment.Assistant != oldAppointment.Assistant) {
				return true;
			}
			if(appointment.ClinicNum != oldAppointment.ClinicNum) {
				return true;
			}
			if(appointment.IsHygiene != oldAppointment.IsHygiene) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			if(appointment.DateTimeArrived != oldAppointment.DateTimeArrived) {
				return true;
			}
			if(appointment.DateTimeSeated != oldAppointment.DateTimeSeated) {
				return true;
			}
			if(appointment.DateTimeDismissed != oldAppointment.DateTimeDismissed) {
				return true;
			}
			if(appointment.InsPlan1 != oldAppointment.InsPlan1) {
				return true;
			}
			if(appointment.InsPlan2 != oldAppointment.InsPlan2) {
				return true;
			}
			if(appointment.DateTimeAskedToArrive != oldAppointment.DateTimeAskedToArrive) {
				return true;
			}
			if(appointment.ProcsColored != oldAppointment.ProcsColored) {
				return true;
			}
			if(appointment.ColorOverride != oldAppointment.ColorOverride) {
				return true;
			}
			if(appointment.AppointmentTypeNum != oldAppointment.AppointmentTypeNum) {
				return true;
			}
			//SecUserNumEntry excluded from update
			//SecDateTEntry not allowed to change
			if(appointment.Priority != oldAppointment.Priority) {
				return true;
			}
			if(appointment.ProvBarText != oldAppointment.ProvBarText) {
				return true;
			}
			if(appointment.PatternSecondary != oldAppointment.PatternSecondary) {
				return true;
			}
			if(appointment.SecurityHash != oldAppointment.SecurityHash) {
				return true;
			}
			if(appointment.ItemOrderPlanned != oldAppointment.ItemOrderPlanned) {
				return true;
			}
			return false;
		}

		//Delete not allowed for this table
		//public static void Delete(long aptNum) {
		//
		//}

		//Delete not allowed for this table
		//public static void DeleteMany(List<long> listAptNums) {
		//
		//}

		///<summary>Inserts, updates, or deletes database rows to match supplied list.  Returns true if db changes were made.
		///Supply Security.CurUser.UserNum, used to set the SecUserNumEntry field for Inserts.</summary>
		public static bool Sync(List<Appointment> listNew,List<Appointment> listDB,long userNum) {
			//Adding items to lists changes the order of operation. All inserts are completed first, then updates, then deletes.
			List<Appointment> listIns    =new List<Appointment>();
			List<Appointment> listUpdNew =new List<Appointment>();
			List<Appointment> listUpdDB  =new List<Appointment>();
			List<Appointment> listDel    =new List<Appointment>();
			listNew.Sort((Appointment x,Appointment y) => { return x.AptNum.CompareTo(y.AptNum); });
			listDB.Sort((Appointment x,Appointment y) => { return x.AptNum.CompareTo(y.AptNum); });
			int idxNew=0;
			int idxDB=0;
			int rowsUpdatedCount=0;
			Appointment fieldNew;
			Appointment fieldDB;
			//Because both lists have been sorted using the same criteria, we can now walk each list to determine which list contians the next element.  The next element is determined by Primary Key.
			//If the New list contains the next item it will be inserted.  If the DB contains the next item, it will be deleted.  If both lists contain the next item, the item will be updated.
			while(idxNew<listNew.Count || idxDB<listDB.Count) {
				fieldNew=null;
				if(idxNew<listNew.Count) {
					fieldNew=listNew[idxNew];
				}
				fieldDB=null;
				if(idxDB<listDB.Count) {
					fieldDB=listDB[idxDB];
				}
				//begin compare
				if(fieldNew!=null && fieldDB==null) {//listNew has more items, listDB does not.
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew==null && fieldDB!=null) {//listDB has more items, listNew does not.
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				else if(fieldNew.AptNum<fieldDB.AptNum) {//newPK less than dbPK, newItem is 'next'
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew.AptNum>fieldDB.AptNum) {//dbPK less than newPK, dbItem is 'next'
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				//Both lists contain the 'next' item, update required
				listUpdNew.Add(fieldNew);
				listUpdDB.Add(fieldDB);
				idxNew++;
				idxDB++;
			}
			//Commit changes to DB
			for(int i=0;i<listIns.Count;i++) {
				listIns[i].SecUserNumEntry=userNum;
				Insert(listIns[i]);
			}
			for(int i=0;i<listUpdNew.Count;i++) {
				if(Update(listUpdNew[i],listUpdDB[i])) {
					rowsUpdatedCount++;
				}
			}
			for(int i=0;i<listDel.Count;i++) {
				Appointments.Delete(listDel[i].AptNum);
			}
			if(rowsUpdatedCount>0 || listIns.Count>0 || listDel.Count>0) {
				return true;
			}
			return false;
		}

		///<summary>Zeros securitylog FKey column for rows that are using the matching aptNum as FKey and are related to Appointment.
		///Permtypes are generated from the AuditPerms property of the CrudTableAttribute within the Appointment table type.</summary>
		public static void ClearFkey(long aptNum) {
			if(aptNum==0) {
				return;
			}
			string command="UPDATE securitylog SET FKey=0 WHERE FKey="+POut.Long(aptNum)+" AND PermType IN (96,25,27,26,237,238)";
			Db.NonQ(command);
		}

		///<summary>Zeros securitylog FKey column for rows that are using the matching aptNums as FKey and are related to Appointment.
		///Permtypes are generated from the AuditPerms property of the CrudTableAttribute within the Appointment table type.</summary>
		public static void ClearFkey(List<long> listAptNums) {
			if(listAptNums==null || listAptNums.FindAll(x => x != 0).Count==0) {
				return;
			}
			string command="UPDATE securitylog SET FKey=0 WHERE FKey IN("+String.Join(",",listAptNums.FindAll(x => x != 0))+") AND PermType IN (96,25,27,26,237,238)";
			Db.NonQ(command);
		}

	}
}