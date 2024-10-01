//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class ProviderCrud {
		///<summary>Gets one Provider object from the database using the primary key.  Returns null if not found.</summary>
		public static Provider SelectOne(long provNum) {
			string command="SELECT * FROM provider "
				+"WHERE ProvNum = "+POut.Long(provNum);
			List<Provider> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Provider object from the database using a query.</summary>
		public static Provider SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Provider> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Provider objects from the database using a query.</summary>
		public static List<Provider> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Provider> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Provider> TableToList(DataTable table) {
			List<Provider> retVal=new List<Provider>();
			Provider provider;
			foreach(DataRow row in table.Rows) {
				provider=new Provider();
				provider.ProvNum               = PIn.Long  (row["ProvNum"].ToString());
				provider.Abbr                  = PIn.String(row["Abbr"].ToString());
				provider.ItemOrder             = PIn.Int   (row["ItemOrder"].ToString());
				provider.LName                 = PIn.String(row["LName"].ToString());
				provider.FName                 = PIn.String(row["FName"].ToString());
				provider.MI                    = PIn.String(row["MI"].ToString());
				provider.Suffix                = PIn.String(row["Suffix"].ToString());
				provider.FeeSched              = PIn.Long  (row["FeeSched"].ToString());
				provider.Specialty             = PIn.Long  (row["Specialty"].ToString());
				provider.SSN                   = PIn.String(row["SSN"].ToString());
				provider.StateLicense          = PIn.String(row["StateLicense"].ToString());
				provider.DEANum                = PIn.String(row["DEANum"].ToString());
				provider.IsSecondary           = PIn.Bool  (row["IsSecondary"].ToString());
				provider.ProvColor             = Color.FromArgb(PIn.Int(row["ProvColor"].ToString()));
				provider.IsHidden              = PIn.Bool  (row["IsHidden"].ToString());
				provider.UsingTIN              = PIn.Bool  (row["UsingTIN"].ToString());
				provider.BlueCrossID           = PIn.String(row["BlueCrossID"].ToString());
				provider.SigOnFile             = PIn.Bool  (row["SigOnFile"].ToString());
				provider.MedicaidID            = PIn.String(row["MedicaidID"].ToString());
				provider.OutlineColor          = Color.FromArgb(PIn.Int(row["OutlineColor"].ToString()));
				provider.SchoolClassNum        = PIn.Long  (row["SchoolClassNum"].ToString());
				provider.NationalProvID        = PIn.String(row["NationalProvID"].ToString());
				provider.CanadianOfficeNum     = PIn.String(row["CanadianOfficeNum"].ToString());
				provider.DateTStamp            = PIn.DateT (row["DateTStamp"].ToString());
				provider.AnesthProvType        = PIn.Long  (row["AnesthProvType"].ToString());
				provider.TaxonomyCodeOverride  = PIn.String(row["TaxonomyCodeOverride"].ToString());
				provider.IsCDAnet              = PIn.Bool  (row["IsCDAnet"].ToString());
				provider.EcwID                 = PIn.String(row["EcwID"].ToString());
				provider.StateRxID             = PIn.String(row["StateRxID"].ToString());
				provider.IsNotPerson           = PIn.Bool  (row["IsNotPerson"].ToString());
				provider.StateWhereLicensed    = PIn.String(row["StateWhereLicensed"].ToString());
				provider.EmailAddressNum       = PIn.Long  (row["EmailAddressNum"].ToString());
				provider.IsInstructor          = PIn.Bool  (row["IsInstructor"].ToString());
				provider.EhrMuStage            = PIn.Int   (row["EhrMuStage"].ToString());
				provider.ProvNumBillingOverride= PIn.Long  (row["ProvNumBillingOverride"].ToString());
				provider.CustomID              = PIn.String(row["CustomID"].ToString());
				provider.ProvStatus            = (OpenDentBusiness.ProviderStatus)PIn.Int(row["ProvStatus"].ToString());
				provider.IsHiddenReport        = PIn.Bool  (row["IsHiddenReport"].ToString());
				provider.IsErxEnabled          = (OpenDentBusiness.ErxEnabledStatus)PIn.Int(row["IsErxEnabled"].ToString());
				provider.SchedNote             = PIn.String(row["SchedNote"].ToString());
				provider.Birthdate             = PIn.Date  (row["Birthdate"].ToString());
				provider.WebSchedDescript      = PIn.String(row["WebSchedDescript"].ToString());
				provider.WebSchedImageLocation = PIn.String(row["WebSchedImageLocation"].ToString());
				provider.HourlyProdGoalAmt     = PIn.Double(row["HourlyProdGoalAmt"].ToString());
				provider.DateTerm              = PIn.Date  (row["DateTerm"].ToString());
				provider.PreferredName         = PIn.String(row["PreferredName"].ToString());
				retVal.Add(provider);
			}
			return retVal;
		}

		///<summary>Converts a list of Provider into a DataTable.</summary>
		public static DataTable ListToTable(List<Provider> listProviders,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Provider";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ProvNum");
			table.Columns.Add("Abbr");
			table.Columns.Add("ItemOrder");
			table.Columns.Add("LName");
			table.Columns.Add("FName");
			table.Columns.Add("MI");
			table.Columns.Add("Suffix");
			table.Columns.Add("FeeSched");
			table.Columns.Add("Specialty");
			table.Columns.Add("SSN");
			table.Columns.Add("StateLicense");
			table.Columns.Add("DEANum");
			table.Columns.Add("IsSecondary");
			table.Columns.Add("ProvColor");
			table.Columns.Add("IsHidden");
			table.Columns.Add("UsingTIN");
			table.Columns.Add("BlueCrossID");
			table.Columns.Add("SigOnFile");
			table.Columns.Add("MedicaidID");
			table.Columns.Add("OutlineColor");
			table.Columns.Add("SchoolClassNum");
			table.Columns.Add("NationalProvID");
			table.Columns.Add("CanadianOfficeNum");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("AnesthProvType");
			table.Columns.Add("TaxonomyCodeOverride");
			table.Columns.Add("IsCDAnet");
			table.Columns.Add("EcwID");
			table.Columns.Add("StateRxID");
			table.Columns.Add("IsNotPerson");
			table.Columns.Add("StateWhereLicensed");
			table.Columns.Add("EmailAddressNum");
			table.Columns.Add("IsInstructor");
			table.Columns.Add("EhrMuStage");
			table.Columns.Add("ProvNumBillingOverride");
			table.Columns.Add("CustomID");
			table.Columns.Add("ProvStatus");
			table.Columns.Add("IsHiddenReport");
			table.Columns.Add("IsErxEnabled");
			table.Columns.Add("SchedNote");
			table.Columns.Add("Birthdate");
			table.Columns.Add("WebSchedDescript");
			table.Columns.Add("WebSchedImageLocation");
			table.Columns.Add("HourlyProdGoalAmt");
			table.Columns.Add("DateTerm");
			table.Columns.Add("PreferredName");
			foreach(Provider provider in listProviders) {
				table.Rows.Add(new object[] {
					POut.Long  (provider.ProvNum),
					            provider.Abbr,
					POut.Int   (provider.ItemOrder),
					            provider.LName,
					            provider.FName,
					            provider.MI,
					            provider.Suffix,
					POut.Long  (provider.FeeSched),
					POut.Long  (provider.Specialty),
					            provider.SSN,
					            provider.StateLicense,
					            provider.DEANum,
					POut.Bool  (provider.IsSecondary),
					POut.Int   (provider.ProvColor.ToArgb()),
					POut.Bool  (provider.IsHidden),
					POut.Bool  (provider.UsingTIN),
					            provider.BlueCrossID,
					POut.Bool  (provider.SigOnFile),
					            provider.MedicaidID,
					POut.Int   (provider.OutlineColor.ToArgb()),
					POut.Long  (provider.SchoolClassNum),
					            provider.NationalProvID,
					            provider.CanadianOfficeNum,
					POut.DateT (provider.DateTStamp,false),
					POut.Long  (provider.AnesthProvType),
					            provider.TaxonomyCodeOverride,
					POut.Bool  (provider.IsCDAnet),
					            provider.EcwID,
					            provider.StateRxID,
					POut.Bool  (provider.IsNotPerson),
					            provider.StateWhereLicensed,
					POut.Long  (provider.EmailAddressNum),
					POut.Bool  (provider.IsInstructor),
					POut.Int   (provider.EhrMuStage),
					POut.Long  (provider.ProvNumBillingOverride),
					            provider.CustomID,
					POut.Int   ((int)provider.ProvStatus),
					POut.Bool  (provider.IsHiddenReport),
					POut.Int   ((int)provider.IsErxEnabled),
					            provider.SchedNote,
					POut.DateT (provider.Birthdate,false),
					            provider.WebSchedDescript,
					            provider.WebSchedImageLocation,
					POut.Double(provider.HourlyProdGoalAmt),
					POut.DateT (provider.DateTerm,false),
					            provider.PreferredName,
				});
			}
			return table;
		}

		///<summary>Inserts one Provider into the database.  Returns the new priKey.</summary>
		public static long Insert(Provider provider) {
			return Insert(provider,false);
		}

		///<summary>Inserts one Provider into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Provider provider,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				provider.ProvNum=ReplicationServers.GetKey("provider","ProvNum");
			}
			string command="INSERT INTO provider (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ProvNum,";
			}
			command+="Abbr,ItemOrder,LName,FName,MI,Suffix,FeeSched,Specialty,SSN,StateLicense,DEANum,IsSecondary,ProvColor,IsHidden,UsingTIN,BlueCrossID,SigOnFile,MedicaidID,OutlineColor,SchoolClassNum,NationalProvID,CanadianOfficeNum,AnesthProvType,TaxonomyCodeOverride,IsCDAnet,EcwID,StateRxID,IsNotPerson,StateWhereLicensed,EmailAddressNum,IsInstructor,EhrMuStage,ProvNumBillingOverride,CustomID,ProvStatus,IsHiddenReport,IsErxEnabled,SchedNote,Birthdate,WebSchedDescript,WebSchedImageLocation,HourlyProdGoalAmt,DateTerm,PreferredName) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(provider.ProvNum)+",";
			}
			command+=
				 "'"+POut.String(provider.Abbr)+"',"
				+    POut.Int   (provider.ItemOrder)+","
				+"'"+POut.String(provider.LName)+"',"
				+"'"+POut.String(provider.FName)+"',"
				+"'"+POut.String(provider.MI)+"',"
				+"'"+POut.String(provider.Suffix)+"',"
				+    POut.Long  (provider.FeeSched)+","
				+    POut.Long  (provider.Specialty)+","
				+"'"+POut.String(provider.SSN)+"',"
				+"'"+POut.String(provider.StateLicense)+"',"
				+"'"+POut.String(provider.DEANum)+"',"
				+    POut.Bool  (provider.IsSecondary)+","
				+    POut.Int   (provider.ProvColor.ToArgb())+","
				+    POut.Bool  (provider.IsHidden)+","
				+    POut.Bool  (provider.UsingTIN)+","
				+"'"+POut.String(provider.BlueCrossID)+"',"
				+    POut.Bool  (provider.SigOnFile)+","
				+"'"+POut.String(provider.MedicaidID)+"',"
				+    POut.Int   (provider.OutlineColor.ToArgb())+","
				+    POut.Long  (provider.SchoolClassNum)+","
				+"'"+POut.String(provider.NationalProvID)+"',"
				+"'"+POut.String(provider.CanadianOfficeNum)+"',"
				//DateTStamp can only be set by MySQL
				+    POut.Long  (provider.AnesthProvType)+","
				+"'"+POut.String(provider.TaxonomyCodeOverride)+"',"
				+    POut.Bool  (provider.IsCDAnet)+","
				+"'"+POut.String(provider.EcwID)+"',"
				+"'"+POut.String(provider.StateRxID)+"',"
				+    POut.Bool  (provider.IsNotPerson)+","
				+"'"+POut.String(provider.StateWhereLicensed)+"',"
				+    POut.Long  (provider.EmailAddressNum)+","
				+    POut.Bool  (provider.IsInstructor)+","
				+    POut.Int   (provider.EhrMuStage)+","
				+    POut.Long  (provider.ProvNumBillingOverride)+","
				+"'"+POut.String(provider.CustomID)+"',"
				+    POut.Int   ((int)provider.ProvStatus)+","
				+    POut.Bool  (provider.IsHiddenReport)+","
				+    POut.Int   ((int)provider.IsErxEnabled)+","
				+"'"+POut.String(provider.SchedNote)+"',"
				+    POut.Date  (provider.Birthdate)+","
				+"'"+POut.String(provider.WebSchedDescript)+"',"
				+"'"+POut.String(provider.WebSchedImageLocation)+"',"
				+		 POut.Double(provider.HourlyProdGoalAmt)+","
				+    POut.Date  (provider.DateTerm)+","
				+"'"+POut.String(provider.PreferredName)+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				provider.ProvNum=Db.NonQ(command,true,"ProvNum","provider");
			}
			return provider.ProvNum;
		}

		///<summary>Inserts one Provider into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Provider provider) {
			return InsertNoCache(provider,false);
		}

		///<summary>Inserts one Provider into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Provider provider,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO provider (";
			if(!useExistingPK && isRandomKeys) {
				provider.ProvNum=ReplicationServers.GetKeyNoCache("provider","ProvNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ProvNum,";
			}
			command+="Abbr,ItemOrder,LName,FName,MI,Suffix,FeeSched,Specialty,SSN,StateLicense,DEANum,IsSecondary,ProvColor,IsHidden,UsingTIN,BlueCrossID,SigOnFile,MedicaidID,OutlineColor,SchoolClassNum,NationalProvID,CanadianOfficeNum,AnesthProvType,TaxonomyCodeOverride,IsCDAnet,EcwID,StateRxID,IsNotPerson,StateWhereLicensed,EmailAddressNum,IsInstructor,EhrMuStage,ProvNumBillingOverride,CustomID,ProvStatus,IsHiddenReport,IsErxEnabled,SchedNote,Birthdate,WebSchedDescript,WebSchedImageLocation,HourlyProdGoalAmt,DateTerm,PreferredName) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(provider.ProvNum)+",";
			}
			command+=
				 "'"+POut.String(provider.Abbr)+"',"
				+    POut.Int   (provider.ItemOrder)+","
				+"'"+POut.String(provider.LName)+"',"
				+"'"+POut.String(provider.FName)+"',"
				+"'"+POut.String(provider.MI)+"',"
				+"'"+POut.String(provider.Suffix)+"',"
				+    POut.Long  (provider.FeeSched)+","
				+    POut.Long  (provider.Specialty)+","
				+"'"+POut.String(provider.SSN)+"',"
				+"'"+POut.String(provider.StateLicense)+"',"
				+"'"+POut.String(provider.DEANum)+"',"
				+    POut.Bool  (provider.IsSecondary)+","
				+    POut.Int   (provider.ProvColor.ToArgb())+","
				+    POut.Bool  (provider.IsHidden)+","
				+    POut.Bool  (provider.UsingTIN)+","
				+"'"+POut.String(provider.BlueCrossID)+"',"
				+    POut.Bool  (provider.SigOnFile)+","
				+"'"+POut.String(provider.MedicaidID)+"',"
				+    POut.Int   (provider.OutlineColor.ToArgb())+","
				+    POut.Long  (provider.SchoolClassNum)+","
				+"'"+POut.String(provider.NationalProvID)+"',"
				+"'"+POut.String(provider.CanadianOfficeNum)+"',"
				//DateTStamp can only be set by MySQL
				+    POut.Long  (provider.AnesthProvType)+","
				+"'"+POut.String(provider.TaxonomyCodeOverride)+"',"
				+    POut.Bool  (provider.IsCDAnet)+","
				+"'"+POut.String(provider.EcwID)+"',"
				+"'"+POut.String(provider.StateRxID)+"',"
				+    POut.Bool  (provider.IsNotPerson)+","
				+"'"+POut.String(provider.StateWhereLicensed)+"',"
				+    POut.Long  (provider.EmailAddressNum)+","
				+    POut.Bool  (provider.IsInstructor)+","
				+    POut.Int   (provider.EhrMuStage)+","
				+    POut.Long  (provider.ProvNumBillingOverride)+","
				+"'"+POut.String(provider.CustomID)+"',"
				+    POut.Int   ((int)provider.ProvStatus)+","
				+    POut.Bool  (provider.IsHiddenReport)+","
				+    POut.Int   ((int)provider.IsErxEnabled)+","
				+"'"+POut.String(provider.SchedNote)+"',"
				+    POut.Date  (provider.Birthdate)+","
				+"'"+POut.String(provider.WebSchedDescript)+"',"
				+"'"+POut.String(provider.WebSchedImageLocation)+"',"
				+	   POut.Double(provider.HourlyProdGoalAmt)+","
				+    POut.Date  (provider.DateTerm)+","
				+"'"+POut.String(provider.PreferredName)+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				provider.ProvNum=Db.NonQ(command,true,"ProvNum","provider");
			}
			return provider.ProvNum;
		}

		///<summary>Updates one Provider in the database.</summary>
		public static void Update(Provider provider) {
			string command="UPDATE provider SET "
				+"Abbr                  = '"+POut.String(provider.Abbr)+"', "
				+"ItemOrder             =  "+POut.Int   (provider.ItemOrder)+", "
				+"LName                 = '"+POut.String(provider.LName)+"', "
				+"FName                 = '"+POut.String(provider.FName)+"', "
				+"MI                    = '"+POut.String(provider.MI)+"', "
				+"Suffix                = '"+POut.String(provider.Suffix)+"', "
				+"FeeSched              =  "+POut.Long  (provider.FeeSched)+", "
				+"Specialty             =  "+POut.Long  (provider.Specialty)+", "
				+"SSN                   = '"+POut.String(provider.SSN)+"', "
				+"StateLicense          = '"+POut.String(provider.StateLicense)+"', "
				+"DEANum                = '"+POut.String(provider.DEANum)+"', "
				+"IsSecondary           =  "+POut.Bool  (provider.IsSecondary)+", "
				+"ProvColor             =  "+POut.Int   (provider.ProvColor.ToArgb())+", "
				+"IsHidden              =  "+POut.Bool  (provider.IsHidden)+", "
				+"UsingTIN              =  "+POut.Bool  (provider.UsingTIN)+", "
				+"BlueCrossID           = '"+POut.String(provider.BlueCrossID)+"', "
				+"SigOnFile             =  "+POut.Bool  (provider.SigOnFile)+", "
				+"MedicaidID            = '"+POut.String(provider.MedicaidID)+"', "
				+"OutlineColor          =  "+POut.Int   (provider.OutlineColor.ToArgb())+", "
				+"SchoolClassNum        =  "+POut.Long  (provider.SchoolClassNum)+", "
				+"NationalProvID        = '"+POut.String(provider.NationalProvID)+"', "
				+"CanadianOfficeNum     = '"+POut.String(provider.CanadianOfficeNum)+"', "
				//DateTStamp can only be set by MySQL
				+"AnesthProvType        =  "+POut.Long  (provider.AnesthProvType)+", "
				+"TaxonomyCodeOverride  = '"+POut.String(provider.TaxonomyCodeOverride)+"', "
				+"IsCDAnet              =  "+POut.Bool  (provider.IsCDAnet)+", "
				+"EcwID                 = '"+POut.String(provider.EcwID)+"', "
				+"StateRxID             = '"+POut.String(provider.StateRxID)+"', "
				+"IsNotPerson           =  "+POut.Bool  (provider.IsNotPerson)+", "
				+"StateWhereLicensed    = '"+POut.String(provider.StateWhereLicensed)+"', "
				+"EmailAddressNum       =  "+POut.Long  (provider.EmailAddressNum)+", "
				+"IsInstructor          =  "+POut.Bool  (provider.IsInstructor)+", "
				+"EhrMuStage            =  "+POut.Int   (provider.EhrMuStage)+", "
				+"ProvNumBillingOverride=  "+POut.Long  (provider.ProvNumBillingOverride)+", "
				+"CustomID              = '"+POut.String(provider.CustomID)+"', "
				+"ProvStatus            =  "+POut.Int   ((int)provider.ProvStatus)+", "
				+"IsHiddenReport        =  "+POut.Bool  (provider.IsHiddenReport)+", "
				+"IsErxEnabled          =  "+POut.Int   ((int)provider.IsErxEnabled)+", "
				+"SchedNote             = '"+POut.String(provider.SchedNote)+"', "
				+"Birthdate             =  "+POut.Date  (provider.Birthdate)+", "
				+"WebSchedDescript      = '"+POut.String(provider.WebSchedDescript)+"', "
				+"WebSchedImageLocation = '"+POut.String(provider.WebSchedImageLocation)+"', "
				+"HourlyProdGoalAmt     =  "+POut.Double(provider.HourlyProdGoalAmt)+", "
				+"DateTerm              =  "+POut.Date  (provider.DateTerm)+", "
				+"PreferredName         = '"+POut.String(provider.PreferredName)+"' "
				+"WHERE ProvNum = "+POut.Long(provider.ProvNum);
			Db.NonQ(command);
		}

		///<summary>Updates one Provider in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Provider provider,Provider oldProvider) {
			string command="";
			if(provider.Abbr != oldProvider.Abbr) {
				if(command!="") { command+=",";}
				command+="Abbr = '"+POut.String(provider.Abbr)+"'";
			}
			if(provider.ItemOrder != oldProvider.ItemOrder) {
				if(command!="") { command+=",";}
				command+="ItemOrder = "+POut.Int(provider.ItemOrder)+"";
			}
			if(provider.LName != oldProvider.LName) {
				if(command!="") { command+=",";}
				command+="LName = '"+POut.String(provider.LName)+"'";
			}
			if(provider.FName != oldProvider.FName) {
				if(command!="") { command+=",";}
				command+="FName = '"+POut.String(provider.FName)+"'";
			}
			if(provider.MI != oldProvider.MI) {
				if(command!="") { command+=",";}
				command+="MI = '"+POut.String(provider.MI)+"'";
			}
			if(provider.Suffix != oldProvider.Suffix) {
				if(command!="") { command+=",";}
				command+="Suffix = '"+POut.String(provider.Suffix)+"'";
			}
			if(provider.FeeSched != oldProvider.FeeSched) {
				if(command!="") { command+=",";}
				command+="FeeSched = "+POut.Long(provider.FeeSched)+"";
			}
			if(provider.Specialty != oldProvider.Specialty) {
				if(command!="") { command+=",";}
				command+="Specialty = "+POut.Long(provider.Specialty)+"";
			}
			if(provider.SSN != oldProvider.SSN) {
				if(command!="") { command+=",";}
				command+="SSN = '"+POut.String(provider.SSN)+"'";
			}
			if(provider.StateLicense != oldProvider.StateLicense) {
				if(command!="") { command+=",";}
				command+="StateLicense = '"+POut.String(provider.StateLicense)+"'";
			}
			if(provider.DEANum != oldProvider.DEANum) {
				if(command!="") { command+=",";}
				command+="DEANum = '"+POut.String(provider.DEANum)+"'";
			}
			if(provider.IsSecondary != oldProvider.IsSecondary) {
				if(command!="") { command+=",";}
				command+="IsSecondary = "+POut.Bool(provider.IsSecondary)+"";
			}
			if(provider.ProvColor != oldProvider.ProvColor) {
				if(command!="") { command+=",";}
				command+="ProvColor = "+POut.Int(provider.ProvColor.ToArgb())+"";
			}
			if(provider.IsHidden != oldProvider.IsHidden) {
				if(command!="") { command+=",";}
				command+="IsHidden = "+POut.Bool(provider.IsHidden)+"";
			}
			if(provider.UsingTIN != oldProvider.UsingTIN) {
				if(command!="") { command+=",";}
				command+="UsingTIN = "+POut.Bool(provider.UsingTIN)+"";
			}
			if(provider.BlueCrossID != oldProvider.BlueCrossID) {
				if(command!="") { command+=",";}
				command+="BlueCrossID = '"+POut.String(provider.BlueCrossID)+"'";
			}
			if(provider.SigOnFile != oldProvider.SigOnFile) {
				if(command!="") { command+=",";}
				command+="SigOnFile = "+POut.Bool(provider.SigOnFile)+"";
			}
			if(provider.MedicaidID != oldProvider.MedicaidID) {
				if(command!="") { command+=",";}
				command+="MedicaidID = '"+POut.String(provider.MedicaidID)+"'";
			}
			if(provider.OutlineColor != oldProvider.OutlineColor) {
				if(command!="") { command+=",";}
				command+="OutlineColor = "+POut.Int(provider.OutlineColor.ToArgb())+"";
			}
			if(provider.SchoolClassNum != oldProvider.SchoolClassNum) {
				if(command!="") { command+=",";}
				command+="SchoolClassNum = "+POut.Long(provider.SchoolClassNum)+"";
			}
			if(provider.NationalProvID != oldProvider.NationalProvID) {
				if(command!="") { command+=",";}
				command+="NationalProvID = '"+POut.String(provider.NationalProvID)+"'";
			}
			if(provider.CanadianOfficeNum != oldProvider.CanadianOfficeNum) {
				if(command!="") { command+=",";}
				command+="CanadianOfficeNum = '"+POut.String(provider.CanadianOfficeNum)+"'";
			}
			//DateTStamp can only be set by MySQL
			if(provider.AnesthProvType != oldProvider.AnesthProvType) {
				if(command!="") { command+=",";}
				command+="AnesthProvType = "+POut.Long(provider.AnesthProvType)+"";
			}
			if(provider.TaxonomyCodeOverride != oldProvider.TaxonomyCodeOverride) {
				if(command!="") { command+=",";}
				command+="TaxonomyCodeOverride = '"+POut.String(provider.TaxonomyCodeOverride)+"'";
			}
			if(provider.IsCDAnet != oldProvider.IsCDAnet) {
				if(command!="") { command+=",";}
				command+="IsCDAnet = "+POut.Bool(provider.IsCDAnet)+"";
			}
			if(provider.EcwID != oldProvider.EcwID) {
				if(command!="") { command+=",";}
				command+="EcwID = '"+POut.String(provider.EcwID)+"'";
			}
			if(provider.StateRxID != oldProvider.StateRxID) {
				if(command!="") { command+=",";}
				command+="StateRxID = '"+POut.String(provider.StateRxID)+"'";
			}
			if(provider.IsNotPerson != oldProvider.IsNotPerson) {
				if(command!="") { command+=",";}
				command+="IsNotPerson = "+POut.Bool(provider.IsNotPerson)+"";
			}
			if(provider.StateWhereLicensed != oldProvider.StateWhereLicensed) {
				if(command!="") { command+=",";}
				command+="StateWhereLicensed = '"+POut.String(provider.StateWhereLicensed)+"'";
			}
			if(provider.EmailAddressNum != oldProvider.EmailAddressNum) {
				if(command!="") { command+=",";}
				command+="EmailAddressNum = "+POut.Long(provider.EmailAddressNum)+"";
			}
			if(provider.IsInstructor != oldProvider.IsInstructor) {
				if(command!="") { command+=",";}
				command+="IsInstructor = "+POut.Bool(provider.IsInstructor)+"";
			}
			if(provider.EhrMuStage != oldProvider.EhrMuStage) {
				if(command!="") { command+=",";}
				command+="EhrMuStage = "+POut.Int(provider.EhrMuStage)+"";
			}
			if(provider.ProvNumBillingOverride != oldProvider.ProvNumBillingOverride) {
				if(command!="") { command+=",";}
				command+="ProvNumBillingOverride = "+POut.Long(provider.ProvNumBillingOverride)+"";
			}
			if(provider.CustomID != oldProvider.CustomID) {
				if(command!="") { command+=",";}
				command+="CustomID = '"+POut.String(provider.CustomID)+"'";
			}
			if(provider.ProvStatus != oldProvider.ProvStatus) {
				if(command!="") { command+=",";}
				command+="ProvStatus = "+POut.Int   ((int)provider.ProvStatus)+"";
			}
			if(provider.IsHiddenReport != oldProvider.IsHiddenReport) {
				if(command!="") { command+=",";}
				command+="IsHiddenReport = "+POut.Bool(provider.IsHiddenReport)+"";
			}
			if(provider.IsErxEnabled != oldProvider.IsErxEnabled) {
				if(command!="") { command+=",";}
				command+="IsErxEnabled = "+POut.Int   ((int)provider.IsErxEnabled)+"";
			}
			if(provider.SchedNote != oldProvider.SchedNote) {
				if(command!="") { command+=",";}
				command+="SchedNote = '"+POut.String(provider.SchedNote)+"'";
			}
			if(provider.Birthdate.Date != oldProvider.Birthdate.Date) {
				if(command!="") { command+=",";}
				command+="Birthdate = "+POut.Date(provider.Birthdate)+"";
			}
			if(provider.WebSchedDescript != oldProvider.WebSchedDescript) {
				if(command!="") { command+=",";}
				command+="WebSchedDescript = '"+POut.String(provider.WebSchedDescript)+"'";
			}
			if(provider.WebSchedImageLocation != oldProvider.WebSchedImageLocation) {
				if(command!="") { command+=",";}
				command+="WebSchedImageLocation = '"+POut.String(provider.WebSchedImageLocation)+"'";
			}
			if(provider.HourlyProdGoalAmt != oldProvider.HourlyProdGoalAmt) {
				if(command!="") { command+=",";}
				command+="HourlyProdGoalAmt = "+POut.Double(provider.HourlyProdGoalAmt)+"";
			}
			if(provider.DateTerm.Date != oldProvider.DateTerm.Date) {
				if(command!="") { command+=",";}
				command+="DateTerm = "+POut.Date(provider.DateTerm)+"";
			}
			if(provider.PreferredName != oldProvider.PreferredName) {
				if(command!="") { command+=",";}
				command+="PreferredName = '"+POut.String(provider.PreferredName)+"'";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE provider SET "+command
				+" WHERE ProvNum = "+POut.Long(provider.ProvNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Provider,Provider) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Provider provider,Provider oldProvider) {
			if(provider.Abbr != oldProvider.Abbr) {
				return true;
			}
			if(provider.ItemOrder != oldProvider.ItemOrder) {
				return true;
			}
			if(provider.LName != oldProvider.LName) {
				return true;
			}
			if(provider.FName != oldProvider.FName) {
				return true;
			}
			if(provider.MI != oldProvider.MI) {
				return true;
			}
			if(provider.Suffix != oldProvider.Suffix) {
				return true;
			}
			if(provider.FeeSched != oldProvider.FeeSched) {
				return true;
			}
			if(provider.Specialty != oldProvider.Specialty) {
				return true;
			}
			if(provider.SSN != oldProvider.SSN) {
				return true;
			}
			if(provider.StateLicense != oldProvider.StateLicense) {
				return true;
			}
			if(provider.DEANum != oldProvider.DEANum) {
				return true;
			}
			if(provider.IsSecondary != oldProvider.IsSecondary) {
				return true;
			}
			if(provider.ProvColor != oldProvider.ProvColor) {
				return true;
			}
			if(provider.IsHidden != oldProvider.IsHidden) {
				return true;
			}
			if(provider.UsingTIN != oldProvider.UsingTIN) {
				return true;
			}
			if(provider.BlueCrossID != oldProvider.BlueCrossID) {
				return true;
			}
			if(provider.SigOnFile != oldProvider.SigOnFile) {
				return true;
			}
			if(provider.MedicaidID != oldProvider.MedicaidID) {
				return true;
			}
			if(provider.OutlineColor != oldProvider.OutlineColor) {
				return true;
			}
			if(provider.SchoolClassNum != oldProvider.SchoolClassNum) {
				return true;
			}
			if(provider.NationalProvID != oldProvider.NationalProvID) {
				return true;
			}
			if(provider.CanadianOfficeNum != oldProvider.CanadianOfficeNum) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			if(provider.AnesthProvType != oldProvider.AnesthProvType) {
				return true;
			}
			if(provider.TaxonomyCodeOverride != oldProvider.TaxonomyCodeOverride) {
				return true;
			}
			if(provider.IsCDAnet != oldProvider.IsCDAnet) {
				return true;
			}
			if(provider.EcwID != oldProvider.EcwID) {
				return true;
			}
			if(provider.StateRxID != oldProvider.StateRxID) {
				return true;
			}
			if(provider.IsNotPerson != oldProvider.IsNotPerson) {
				return true;
			}
			if(provider.StateWhereLicensed != oldProvider.StateWhereLicensed) {
				return true;
			}
			if(provider.EmailAddressNum != oldProvider.EmailAddressNum) {
				return true;
			}
			if(provider.IsInstructor != oldProvider.IsInstructor) {
				return true;
			}
			if(provider.EhrMuStage != oldProvider.EhrMuStage) {
				return true;
			}
			if(provider.ProvNumBillingOverride != oldProvider.ProvNumBillingOverride) {
				return true;
			}
			if(provider.CustomID != oldProvider.CustomID) {
				return true;
			}
			if(provider.ProvStatus != oldProvider.ProvStatus) {
				return true;
			}
			if(provider.IsHiddenReport != oldProvider.IsHiddenReport) {
				return true;
			}
			if(provider.IsErxEnabled != oldProvider.IsErxEnabled) {
				return true;
			}
			if(provider.SchedNote != oldProvider.SchedNote) {
				return true;
			}
			if(provider.Birthdate.Date != oldProvider.Birthdate.Date) {
				return true;
			}
			if(provider.WebSchedDescript != oldProvider.WebSchedDescript) {
				return true;
			}
			if(provider.WebSchedImageLocation != oldProvider.WebSchedImageLocation) {
				return true;
			}
			if(provider.HourlyProdGoalAmt != oldProvider.HourlyProdGoalAmt) {
				return true;
			}
			if(provider.DateTerm.Date != oldProvider.DateTerm.Date) {
				return true;
			}
			if(provider.PreferredName != oldProvider.PreferredName) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Provider from the database.</summary>
		public static void Delete(long provNum) {
			string command="DELETE FROM provider "
				+"WHERE ProvNum = "+POut.Long(provNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many Providers from the database.</summary>
		public static void DeleteMany(List<long> listProvNums) {
			if(listProvNums==null || listProvNums.Count==0) {
				return;
			}
			string command="DELETE FROM provider "
				+"WHERE ProvNum IN("+string.Join(",",listProvNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}