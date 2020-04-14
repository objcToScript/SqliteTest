using System;
using System.IO;
using System.Text;

 public partial class clsFile {

   StreamWriter sw;
   StreamReader sr;
   StringReader stri;
   string movePath="";
   string encodeCode="";
   string errorMes;

   private static clsFile singleton;

   public static clsFile _sharedObject() {
     if (singleton == null) {
       singleton = new clsFile();
     }
     return singleton;
   }

   public clsFile(){
     errorMes = "";
   }
 
   private void _console(Exception en) {
     Console.WriteLine(en.Message);
     Console.WriteLine(en.StackTrace);
     Console.WriteLine(en.TargetSite);
     errorMes += en.Message;

     System.Diagnostics.Debug.WriteLine(en.Message);
   }    

   public void _copy(string filePath_t, string movePath_t) {
     errorMes = "";
       if(File.Exists(filePath_t) && filePath_t != "" && movePath_t != "") {
         File.Copy(filePath_t, movePath_t, true);
       } else {
         Console.WriteLine(filePath_t + " がありません。   ");
         errorMes = filePath_t + " がありません。";
       }

       if (!File.Exists(movePath_t)) {
         Console.WriteLine(movePath_t + " がありません。   ");
         errorMes = movePath_t + " がありません。";
       }

   }

   public string[] _loadArrayLine(string filePath) {
     errorMes = "";

       this.encodeCode = this.encodeCode != "" ? this.encodeCode : "UTF-8";

       if(!File.Exists(filePath) || filePath == "") {
         errorMes = filePath + " がありません。";
         return null;
       }
       sr = new StreamReader(filePath,System.Text.Encoding.GetEncoding(this.encodeCode));
       string s = sr.ReadToEnd().Replace("\r","");
       string[] lineArray = s.Split(new char[]{'\n'});
        sr.Close();

        return lineArray;
   }


   public string _load(string filePath) {
     errorMes = "";

       this.encodeCode = this.encodeCode != "" ? this.encodeCode : "UTF-8";

       if(!File.Exists(filePath) && filePath != "") {
         errorMes = filePath + " がありません。";
         return "";
       }

       sr = new StreamReader(filePath,System.Text.Encoding.GetEncoding(this.encodeCode));
       string s = sr.ReadToEnd();
        sr.Close();

        return s;
      

   }

   public string _loadLine(string textData) {
     errorMes = "";
 

       stri = new StringReader(textData);

        string line;
        string str="";
        while((line = stri.ReadLine()) != null) {
          str += line + Environment.NewLine;
        }

        stri.Close();

        return str;
        
   }

   public void _save(string filePath,string text) {
     errorMes = "";

       string rootDir = Path.GetPathRoot(filePath);

       if(Directory.Exists(rootDir) == false) {
         Console.WriteLine("ディレクトリがない ドライブからの情報がない   ");

        // clsFile._mkMesBox_OkCancel("ドライブからの情報がない ", "エラー");
         return;
       }


       this.encodeCode = this.encodeCode != "" ? this.encodeCode : "UTF-8";
       var dirName = Path.GetDirectoryName(filePath);

       if(Directory.Exists(dirName) == false) {
         Directory.CreateDirectory(dirName);
       }
       if(!File.Exists(filePath) && filePath != "") {
         File.Create(filePath).Close();
       }
       sw = new StreamWriter(filePath,false,
       Encoding.GetEncoding(this.encodeCode));

     
        sw.Write(text);

        sw.Close();
        
   }

 

   public void _delete(string filePath) {
     errorMes = "";
   
       if(File.Exists(filePath) && filePath != "") {
         File.Delete(filePath);
       }        
  
   }

   public void _addSave(string filePath, string text) {
     
       this.encodeCode = this.encodeCode != "" ? this.encodeCode : "UTF-8";

       if(!File.Exists(filePath) && filePath != "") {
         var dirPath = Path.GetDirectoryName(filePath);
         if(Directory.Exists(dirPath)== false) {
           Directory.CreateDirectory(dirPath);
         }
         File.Create(filePath).Close();
       }

       sw = new System.IO.StreamWriter(filePath,true,Encoding.GetEncoding(this.encodeCode));
       sw.Write(text);
       sw.Close();   

   }


  
 


   public string EncodeCode {
     set {
       this.encodeCode = value;
     }
     get {
       return this.encodeCode;
     }
   }

   public string MovePath {
     set {
       this.movePath = value;
     }
     get {
       return this.movePath;
     }
   }

   public string ErrorMes {
     get {
       return this.errorMes;
     }
   }





}

