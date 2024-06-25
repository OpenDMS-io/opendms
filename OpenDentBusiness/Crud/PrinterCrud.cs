//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class PrinterCrud {
		///<summary>Gets one Printer object from the database using the primary key.  Returns null if not found.</summary>
		public static Printer SelectOne(long printerNum) {
			string command="SELECT * FROM printer "
				+"WHERE PrinterNum = "+POut.Long(printerNum);
			List<Printer> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Printer object from the database using a query.</summary>
		public static Printer SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Printer> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Printer objects from the database using a query.</summary>
		public static List<Printer> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Printer> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Printer> TableToList(DataTable table) {
			List<Printer> retVal=new List<Printer>();
			Printer printer;
			foreach(DataRow row in table.Rows) {
				printer=new Printer();
				printer.PrinterNum      = PIn.Long  (row["PrinterNum"].ToString());
				printer.ComputerNum     = PIn.Long  (row["ComputerNum"].ToString());
				printer.PrintSit        = (CodeBase.PrintSituation)PIn.Int(row["PrintSit"].ToString());
				printer.PrinterName     = PIn.String(row["PrinterName"].ToString());
				printer.DisplayPrompt   = PIn.Bool  (row["DisplayPrompt"].ToString());
				printer.FileExtension   = PIn.String(row["FileExtension"].ToString());
				printer.IsVirtualPrinter= PIn.Bool  (row["IsVirtualPrinter"].ToString());
				retVal.Add(printer);
			}
			return retVal;
		}

		///<summary>Converts a list of Printer into a DataTable.</summary>
		public static DataTable ListToTable(List<Printer> listPrinters,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Printer";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("PrinterNum");
			table.Columns.Add("ComputerNum");
			table.Columns.Add("PrintSit");
			table.Columns.Add("PrinterName");
			table.Columns.Add("DisplayPrompt");
			table.Columns.Add("FileExtension");
			table.Columns.Add("IsVirtualPrinter");
			foreach(Printer printer in listPrinters) {
				table.Rows.Add(new object[] {
					POut.Long  (printer.PrinterNum),
					POut.Long  (printer.ComputerNum),
					POut.Int   ((int)printer.PrintSit),
					            printer.PrinterName,
					POut.Bool  (printer.DisplayPrompt),
					            printer.FileExtension,
					POut.Bool  (printer.IsVirtualPrinter),
				});
			}
			return table;
		}

		///<summary>Inserts one Printer into the database.  Returns the new priKey.</summary>
		public static long Insert(Printer printer) {
			return Insert(printer,false);
		}

		///<summary>Inserts one Printer into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Printer printer,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				printer.PrinterNum=ReplicationServers.GetKey("printer","PrinterNum");
			}
			string command="INSERT INTO printer (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="PrinterNum,";
			}
			command+="ComputerNum,PrintSit,PrinterName,DisplayPrompt,FileExtension,IsVirtualPrinter) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(printer.PrinterNum)+",";
			}
			command+=
				     POut.Long  (printer.ComputerNum)+","
				+    POut.Int   ((int)printer.PrintSit)+","
				+"'"+POut.String(printer.PrinterName)+"',"
				+    POut.Bool  (printer.DisplayPrompt)+","
				+"'"+POut.String(printer.FileExtension)+"',"
				+    POut.Bool  (printer.IsVirtualPrinter)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				printer.PrinterNum=Db.NonQ(command,true,"PrinterNum","printer");
			}
			return printer.PrinterNum;
		}

		///<summary>Inserts one Printer into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Printer printer) {
			return InsertNoCache(printer,false);
		}

		///<summary>Inserts one Printer into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Printer printer,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO printer (";
			if(!useExistingPK && isRandomKeys) {
				printer.PrinterNum=ReplicationServers.GetKeyNoCache("printer","PrinterNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="PrinterNum,";
			}
			command+="ComputerNum,PrintSit,PrinterName,DisplayPrompt,FileExtension,IsVirtualPrinter) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(printer.PrinterNum)+",";
			}
			command+=
				     POut.Long  (printer.ComputerNum)+","
				+    POut.Int   ((int)printer.PrintSit)+","
				+"'"+POut.String(printer.PrinterName)+"',"
				+    POut.Bool  (printer.DisplayPrompt)+","
				+"'"+POut.String(printer.FileExtension)+"',"
				+    POut.Bool  (printer.IsVirtualPrinter)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				printer.PrinterNum=Db.NonQ(command,true,"PrinterNum","printer");
			}
			return printer.PrinterNum;
		}

		///<summary>Updates one Printer in the database.</summary>
		public static void Update(Printer printer) {
			string command="UPDATE printer SET "
				+"ComputerNum     =  "+POut.Long  (printer.ComputerNum)+", "
				+"PrintSit        =  "+POut.Int   ((int)printer.PrintSit)+", "
				+"PrinterName     = '"+POut.String(printer.PrinterName)+"', "
				+"DisplayPrompt   =  "+POut.Bool  (printer.DisplayPrompt)+", "
				+"FileExtension   = '"+POut.String(printer.FileExtension)+"', "
				+"IsVirtualPrinter=  "+POut.Bool  (printer.IsVirtualPrinter)+" "
				+"WHERE PrinterNum = "+POut.Long(printer.PrinterNum);
			Db.NonQ(command);
		}

		///<summary>Updates one Printer in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Printer printer,Printer oldPrinter) {
			string command="";
			if(printer.ComputerNum != oldPrinter.ComputerNum) {
				if(command!="") { command+=",";}
				command+="ComputerNum = "+POut.Long(printer.ComputerNum)+"";
			}
			if(printer.PrintSit != oldPrinter.PrintSit) {
				if(command!="") { command+=",";}
				command+="PrintSit = "+POut.Int   ((int)printer.PrintSit)+"";
			}
			if(printer.PrinterName != oldPrinter.PrinterName) {
				if(command!="") { command+=",";}
				command+="PrinterName = '"+POut.String(printer.PrinterName)+"'";
			}
			if(printer.DisplayPrompt != oldPrinter.DisplayPrompt) {
				if(command!="") { command+=",";}
				command+="DisplayPrompt = "+POut.Bool(printer.DisplayPrompt)+"";
			}
			if(printer.FileExtension != oldPrinter.FileExtension) {
				if(command!="") { command+=",";}
				command+="FileExtension = '"+POut.String(printer.FileExtension)+"'";
			}
			if(printer.IsVirtualPrinter != oldPrinter.IsVirtualPrinter) {
				if(command!="") { command+=",";}
				command+="IsVirtualPrinter = "+POut.Bool(printer.IsVirtualPrinter)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE printer SET "+command
				+" WHERE PrinterNum = "+POut.Long(printer.PrinterNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Printer,Printer) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Printer printer,Printer oldPrinter) {
			if(printer.ComputerNum != oldPrinter.ComputerNum) {
				return true;
			}
			if(printer.PrintSit != oldPrinter.PrintSit) {
				return true;
			}
			if(printer.PrinterName != oldPrinter.PrinterName) {
				return true;
			}
			if(printer.DisplayPrompt != oldPrinter.DisplayPrompt) {
				return true;
			}
			if(printer.FileExtension != oldPrinter.FileExtension) {
				return true;
			}
			if(printer.IsVirtualPrinter != oldPrinter.IsVirtualPrinter) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Printer from the database.</summary>
		public static void Delete(long printerNum) {
			string command="DELETE FROM printer "
				+"WHERE PrinterNum = "+POut.Long(printerNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Printers from the database.</summary>
		public static void DeleteMany(List<long> listPrinterNums) {
			if(listPrinterNums==null || listPrinterNums.Count==0) {
				return;
			}
			string command="DELETE FROM printer "
				+"WHERE PrinterNum IN("+string.Join(",",listPrinterNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}