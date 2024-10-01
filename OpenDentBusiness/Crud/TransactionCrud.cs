//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class TransactionCrud {
		///<summary>Gets one Transaction object from the database using the primary key.  Returns null if not found.</summary>
		public static Transaction SelectOne(long transactionNum) {
			string command="SELECT * FROM transaction "
				+"WHERE TransactionNum = "+POut.Long(transactionNum);
			List<Transaction> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Transaction object from the database using a query.</summary>
		public static Transaction SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Transaction> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Transaction objects from the database using a query.</summary>
		public static List<Transaction> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Transaction> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Transaction> TableToList(DataTable table) {
			List<Transaction> retVal=new List<Transaction>();
			Transaction transaction;
			foreach(DataRow row in table.Rows) {
				transaction=new Transaction();
				transaction.TransactionNum       = PIn.Long  (row["TransactionNum"].ToString());
				transaction.DateTimeEntry        = PIn.DateT (row["DateTimeEntry"].ToString());
				transaction.UserNum              = PIn.Long  (row["UserNum"].ToString());
				transaction.DepositNum           = PIn.Long  (row["DepositNum"].ToString());
				transaction.PayNum               = PIn.Long  (row["PayNum"].ToString());
				transaction.SecUserNumEdit       = PIn.Long  (row["SecUserNumEdit"].ToString());
				transaction.SecDateTEdit         = PIn.DateT (row["SecDateTEdit"].ToString());
				transaction.TransactionInvoiceNum= PIn.Long  (row["TransactionInvoiceNum"].ToString());
				retVal.Add(transaction);
			}
			return retVal;
		}

		///<summary>Converts a list of Transaction into a DataTable.</summary>
		public static DataTable ListToTable(List<Transaction> listTransactions,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Transaction";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("TransactionNum");
			table.Columns.Add("DateTimeEntry");
			table.Columns.Add("UserNum");
			table.Columns.Add("DepositNum");
			table.Columns.Add("PayNum");
			table.Columns.Add("SecUserNumEdit");
			table.Columns.Add("SecDateTEdit");
			table.Columns.Add("TransactionInvoiceNum");
			foreach(Transaction transaction in listTransactions) {
				table.Rows.Add(new object[] {
					POut.Long  (transaction.TransactionNum),
					POut.DateT (transaction.DateTimeEntry,false),
					POut.Long  (transaction.UserNum),
					POut.Long  (transaction.DepositNum),
					POut.Long  (transaction.PayNum),
					POut.Long  (transaction.SecUserNumEdit),
					POut.DateT (transaction.SecDateTEdit,false),
					POut.Long  (transaction.TransactionInvoiceNum),
				});
			}
			return table;
		}

		///<summary>Inserts one Transaction into the database.  Returns the new priKey.</summary>
		public static long Insert(Transaction transaction) {
			return Insert(transaction,false);
		}

		///<summary>Inserts one Transaction into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Transaction transaction,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				transaction.TransactionNum=ReplicationServers.GetKey("transaction","TransactionNum");
			}
			string command="INSERT INTO transaction (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="TransactionNum,";
			}
			command+="DateTimeEntry,UserNum,DepositNum,PayNum,SecUserNumEdit,TransactionInvoiceNum) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(transaction.TransactionNum)+",";
			}
			command+=
				     DbHelper.Now()+","
				+    POut.Long  (transaction.UserNum)+","
				+    POut.Long  (transaction.DepositNum)+","
				+    POut.Long  (transaction.PayNum)+","
				+    POut.Long  (transaction.SecUserNumEdit)+","
				//SecDateTEdit can only be set by MySQL
				+    POut.Long  (transaction.TransactionInvoiceNum)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				transaction.TransactionNum=Db.NonQ(command,true,"TransactionNum","transaction");
			}
			return transaction.TransactionNum;
		}

		///<summary>Inserts one Transaction into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Transaction transaction) {
			return InsertNoCache(transaction,false);
		}

		///<summary>Inserts one Transaction into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Transaction transaction,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO transaction (";
			if(!useExistingPK && isRandomKeys) {
				transaction.TransactionNum=ReplicationServers.GetKeyNoCache("transaction","TransactionNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="TransactionNum,";
			}
			command+="DateTimeEntry,UserNum,DepositNum,PayNum,SecUserNumEdit,TransactionInvoiceNum) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(transaction.TransactionNum)+",";
			}
			command+=
				     DbHelper.Now()+","
				+    POut.Long  (transaction.UserNum)+","
				+    POut.Long  (transaction.DepositNum)+","
				+    POut.Long  (transaction.PayNum)+","
				+    POut.Long  (transaction.SecUserNumEdit)+","
				//SecDateTEdit can only be set by MySQL
				+    POut.Long  (transaction.TransactionInvoiceNum)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				transaction.TransactionNum=Db.NonQ(command,true,"TransactionNum","transaction");
			}
			return transaction.TransactionNum;
		}

		///<summary>Updates one Transaction in the database.</summary>
		public static void Update(Transaction transaction) {
			string command="UPDATE transaction SET "
				//DateTimeEntry not allowed to change
				//UserNum excluded from update
				+"DepositNum           =  "+POut.Long  (transaction.DepositNum)+", "
				+"PayNum               =  "+POut.Long  (transaction.PayNum)+", "
				+"SecUserNumEdit       =  "+POut.Long  (transaction.SecUserNumEdit)+", "
				//SecDateTEdit can only be set by MySQL
				+"TransactionInvoiceNum=  "+POut.Long  (transaction.TransactionInvoiceNum)+" "
				+"WHERE TransactionNum = "+POut.Long(transaction.TransactionNum);
			Db.NonQ(command);
		}

		///<summary>Updates one Transaction in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Transaction transaction,Transaction oldTransaction) {
			string command="";
			//DateTimeEntry not allowed to change
			//UserNum excluded from update
			if(transaction.DepositNum != oldTransaction.DepositNum) {
				if(command!="") { command+=",";}
				command+="DepositNum = "+POut.Long(transaction.DepositNum)+"";
			}
			if(transaction.PayNum != oldTransaction.PayNum) {
				if(command!="") { command+=",";}
				command+="PayNum = "+POut.Long(transaction.PayNum)+"";
			}
			if(transaction.SecUserNumEdit != oldTransaction.SecUserNumEdit) {
				if(command!="") { command+=",";}
				command+="SecUserNumEdit = "+POut.Long(transaction.SecUserNumEdit)+"";
			}
			//SecDateTEdit can only be set by MySQL
			if(transaction.TransactionInvoiceNum != oldTransaction.TransactionInvoiceNum) {
				if(command!="") { command+=",";}
				command+="TransactionInvoiceNum = "+POut.Long(transaction.TransactionInvoiceNum)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE transaction SET "+command
				+" WHERE TransactionNum = "+POut.Long(transaction.TransactionNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Transaction,Transaction) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Transaction transaction,Transaction oldTransaction) {
			//DateTimeEntry not allowed to change
			//UserNum excluded from update
			if(transaction.DepositNum != oldTransaction.DepositNum) {
				return true;
			}
			if(transaction.PayNum != oldTransaction.PayNum) {
				return true;
			}
			if(transaction.SecUserNumEdit != oldTransaction.SecUserNumEdit) {
				return true;
			}
			//SecDateTEdit can only be set by MySQL
			if(transaction.TransactionInvoiceNum != oldTransaction.TransactionInvoiceNum) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Transaction from the database.</summary>
		public static void Delete(long transactionNum) {
			string command="DELETE FROM transaction "
				+"WHERE TransactionNum = "+POut.Long(transactionNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Transactions from the database.</summary>
		public static void DeleteMany(List<long> listTransactionNums) {
			if(listTransactionNums==null || listTransactionNums.Count==0) {
				return;
			}
			string command="DELETE FROM transaction "
				+"WHERE TransactionNum IN("+string.Join(",",listTransactionNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}