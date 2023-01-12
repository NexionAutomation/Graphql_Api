using ExcelDataReader;
using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.Api.Utility.Custom;
using GraphQl.DATA.API.PO.Model;
using GraphQL_HotChoclate_EFCore.Models;
using GraphQL_HotChoclate_EFCore.Services;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Resolvers;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;

namespace GraphQL_HotChoclate_EFCore.GraphQL
{
    public class PoUserSubscription
    {
        public readonly ILogger Logger12;
        public readonly ICRUD<ResponseData<TmUserMaster>, TmUserMaster> CURED12;
        public readonly poContext _poContext12;

        public PoUserSubscription(poContext _poContext12)
        {
            this._poContext12 = _poContext12;
        }




        //[Subscribe]
        //public string BookPublished( [EventMessage] string book)
        //{
        //  return  "hello";

        //    PublishBook
        //}
         



        [Subscribe]
        public Task<IQueryable<string>> POAutomumbers1( [EventMessage] string sender)
        {
            try
            {
                //[EventMessage] poContext context,

                List<string> tmUserMaster = new List<string>();

                tmUserMaster.Add("hello world");
             // await sender.SendAsync(nameof(POAutomumbers1), sender);

               //context.Automumbers1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        //------------------------------------------------------End Po---------------------------------------------



        //---------------------------------------------------File Uplode ------------------------------------------//
        //public async Task<IQueryable<excelviewer>> UploadFileExcel(IFile files)
        //{
        //    try
        //    {



        //        DataTable csvData = new DataTable();




        //        var FILENAME = "";
        //        FileStream streamWriter;
        //        var ext = "";
        //        string From1 = "";

        //        if (files != null)
        //        {


        //            var filename1 = files.Name;
        //            var dir1 = "";
        //            ext = Path.GetExtension(filename1);
        //            await using var stream1 = files.OpenReadStream();

        //            FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
        //            streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

        //            From1 = streamWriter.Name;


        //            await stream1.CopyToAsync(streamWriter);

        //            streamWriter.Close();

        //            string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

        //            //using (var client = new WebClient())
        //            //{
        //            //    client.Credentials = new NetworkCredential("App", "Nexion@123");
        //            //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

        //            //}
        //        }



        //        using (TextFieldParser csvReader = new TextFieldParser(From1))
        //        {
        //            csvReader.SetDelimiters(new string[] { "," });
        //            csvReader.HasFieldsEnclosedInQuotes = true;
        //            string[] colFields = csvReader.ReadFields();
        //            foreach (string column in colFields)
        //            {
        //                DataColumn datecolumn = new DataColumn(column);
        //                datecolumn.AllowDBNull = true;
        //                csvData.Columns.Add(datecolumn);
        //            }
        //            while (!csvReader.EndOfData)
        //            {
        //                string[] fieldData = csvReader.ReadFields();
        //                //Making empty value as null
        //                for (int i = 0; i < fieldData.Length; i++)
        //                {
        //                    if (fieldData[i] == "")
        //                    {
        //                        fieldData[i] = null;
        //                    }
        //                }
        //                csvData.Rows.Add(fieldData);
        //            }
        //        }



        //        List<excelviewer> studentList = new List<excelviewer>();
        //        for (int i = 0; i < csvData.Rows.Count; i++)
        //        {
        //            excelviewer student = new excelviewer();
        //            student.T1 = csvData.Rows[i][0].ToString();
        //            student.T2 = csvData.Rows[i][1].ToString();
        //            student.T3 = csvData.Rows[i][1].ToString();
        //            student.T4 = csvData.Rows[i][3].ToString();
        //            student.T5 = csvData.Rows[i][4].ToString();
        //            student.T6 = csvData.Rows[i][5].ToString();
        //            student.T7 = csvData.Rows[i][6].ToString();
        //            student.T8 = csvData.Rows[i][7].ToString();
        //            student.T9 = csvData.Rows[i][8].ToString();
        //            student.T10 = csvData.Rows[i][9].ToString();
        //            student.T11 = csvData.Rows[i][10].ToString();
        //            student.T12 = csvData.Rows[i][11].ToString();
        //            student.T13 = csvData.Rows[i][12].ToString();
        //            student.T14 = csvData.Rows[i][13].ToString();
        //            student.T15 = csvData.Rows[i][14].ToString();

        //            studentList.Add(student);
        //        }





        //        //List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
        //        //ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail:  null, Status: "success");
        //        //responseDatas2.Add(dat);
        //        return await Task.Run(() => studentList.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {


        //        List<excelviewer> studentList = new List<excelviewer>();
        //        //ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
        //        //responseDatas2.Add(dat);
        //        return await Task.Run(() => studentList.AsQueryable());
        //    }

        //    finally
        //    {

        //    }

        //}


        //public async Task<IQueryable<ResponseData<string>>> UploadFileExcel002(IFile files)
        //{
        //    try
        //    {



        //        DataTable csvData = new DataTable();




        //        var FILENAME = "";
        //        FileStream streamWriter;
        //        var ext = "";
        //        string From1 = "";

        //        if (files != null)
        //        {


        //            var filename1 = files.Name;
        //            var dir1 = "";
        //            ext = Path.GetExtension(filename1);
        //            await using var stream1 = files.OpenReadStream();

        //            FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
        //            streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

        //            From1 = streamWriter.Name;


        //            await stream1.CopyToAsync(streamWriter);

        //            streamWriter.Close();

        //            string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

        //            //using (var client = new WebClient())
        //            //{
        //            //    client.Credentials = new NetworkCredential("App", "Nexion@123");
        //            //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

        //            //}
        //        }



        //        using (TextFieldParser csvReader = new TextFieldParser(From1))
        //        {
        //            csvReader.SetDelimiters(new string[] { "," });
        //            csvReader.HasFieldsEnclosedInQuotes = true;
        //            string[] colFields = csvReader.ReadFields();
        //            foreach (string column in colFields)
        //            {
        //                DataColumn datecolumn = new DataColumn(column);
        //                datecolumn.AllowDBNull = true;
        //                csvData.Columns.Add(datecolumn);
        //            }
        //            while (!csvReader.EndOfData)
        //            {
        //                string[] fieldData = csvReader.ReadFields();
        //                //Making empty value as null
        //                for (int i = 0; i < fieldData.Length; i++)
        //                {
        //                    if (fieldData[i] == "")
        //                    {
        //                        fieldData[i] = null;
        //                    }
        //                }
        //                csvData.Rows.Add(fieldData);
        //            }
        //        }



        //        List<excelviewer> studentList = new List<excelviewer>();
        //        for (int i = 0; i < csvData.Rows.Count; i++)
        //        {
        //            excelviewer student = new excelviewer();
        //            student.T1 = csvData.Rows[i][0].ToString();
        //            student.T2 = csvData.Rows[i][1].ToString();
        //            student.T3 = csvData.Rows[i][1].ToString();
        //            student.T4 = csvData.Rows[i][3].ToString();
        //            student.T5 = csvData.Rows[i][4].ToString();
        //            student.T6 = csvData.Rows[i][5].ToString();
        //            student.T7 = csvData.Rows[i][6].ToString();
        //            student.T8 = csvData.Rows[i][7].ToString();
        //            student.T9 = csvData.Rows[i][8].ToString();
        //            student.T10 = csvData.Rows[i][9].ToString();
        //            student.T11 = csvData.Rows[i][10].ToString();
        //            student.T12 = csvData.Rows[i][11].ToString();
        //            student.T13 = csvData.Rows[i][12].ToString();
        //            student.T14 = csvData.Rows[i][13].ToString();
        //            student.T15 = csvData.Rows[i][14].ToString();

        //            studentList.Add(student);
        //        }






        //        //string cs = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Downloads\05072022012856.xls';Extended Properties=Excel 8.0;";
        //        //DataTable EmployeeTable = new DataTable();
        //        //OleDbConnection con = new OleDbConnection(cs);
        //        //OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1]", con);
        //        //OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
        //        //oda.Fill(EmployeeTable);
        //        // return EmployeeTable;



        //        //WebRequest request = WebRequest.Create(host + path);
        //        //request.Method = WebRequestMethods.Ftp.MakeDirectory;
        //        //request.Credentials = new NetworkCredential(UserId, Password);
        //        //using (var resp = (FtpWebResponse)request.GetResponse())
        //        //{
        //        //    Console.WriteLine(resp.StatusCode);
        //        //}


        //        //var filename= files.Name;
        //        //var dir = "";
        //        //var ext=Path.GetExtension(filename);
        //        //await using var stream = files.OpenReadStream();


        //        //var streamWriter = new FileStream("FilesData/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ext, FileMode.OpenOrCreate);

        //        //string From = streamWriter.Name;

        //        //dir = "./"+;

        //        // await stream.CopyToAsync(streamWriter);

        //        //streamWriter.Close();



        //        ////@"D:\PO.xlsx";//streamWriter.Name;
        //        ////string To = "ftp://199.102.48.4/"+ DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
        //        //string To = "ftp://182.50.132.58/FileData/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;

        //        //using (var client = new WebClient())
        //        //    {
        //        //        client.Credentials = new NetworkCredential("App", "Nexion@123");
        //        //        client.UploadFile(To, WebRequestMethods.Ftp.UploadFile, From);

        //        //    }










        //        //FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://");

        //        //Request.Method = WebRequestMethods.Ftp.UploadFile;
        //        //Request.Credentials = new NetworkCredential("user", "pass");
        //        //FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();

        //        //Stream ResponseStream = Response.GetResponseStream();
        //        //StreamReader Reader = new StreamReader(ResponseStream);

        //        ////FileInfo[] Files = directoru.GetFiles("*.txt");

        //        ////ListBox1.Items.Add(Response.WelcomeMessage);

        //        ////while (!Reader.EndOfStream)//Read file name   
        //        ////{
        //        ////    ListBox1.Items.Add(Reader.ReadLine().ToString());
        //        ////}
        //        //Response.Close();
        //        //ResponseStream.Close();
        //        //Reader.Close();


        //        //string fullPathToExcel = "./"+ streamWriter.Name; //ie C:\Temp\YourExcel.xls
        //        //string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=yes'", fullPathToExcel);
        //        //DataTable dt = GetDataTable("SELECT * from [Sheet1]", connString);

        //        //foreach (DataRow dr in dt.Rows)
        //        //{
        //        //    //Do what you need to do with your data here
        //        //}








        //        //  GlobalData.me.CoverPhotoLength = stream.Length;

        //        // return GlobalData.me.CoverPhotoLength;


        //        //var fileName = files.Name;
        //        //var fileSize = files.Length;
        //        //await using Stream stream = files.OpenReadStream();
        //        //var path = Environment.CurrentDirectory;

        //        //List<IFile> data = new List<IFile>();
        //        //data.Add(files);


        //        //List<string> result = new List<string>();

        //        //Console.WriteLine(data.Count);

        //        //foreach (var f in data)
        //        //{
        //        //    if (f.Length > 0)
        //        //    {
        //        //        Directory.CreateDirectory("Resources");
        //        //        using (var stream1 = new FileStream("./test.zip", FileMode.OpenOrCreate))
        //        //        {

        //        //            await f.CopyToAsync(stream1);
        //        //            result.Add(f.Name);
        //        //        }
        //        //    }
        //        //}





        //        //using (var writer = File.Create("C:\\"))
        //        //{

        //        //    await stream.CopyToAsync(writer).ConfigureAwait(false);
        //        //}

        //        List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
        //        ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "success");
        //        responseDatas2.Add(dat);
        //        return await Task.Run(() => responseDatas2.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {

        //        List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
        //        ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
        //        responseDatas2.Add(dat);
        //        return await Task.Run(() => responseDatas2.AsQueryable());
        //    }

        //    finally
        //    {

        //    }

        //}




        //--------------------------------------------------- End File Uplode ------------------------------------------//
        //public async Task<bool> UploadFileAsync(IFile file)
        //{
        //    //var fileName = file.Name;
        //    //var fileSize = file.Length;

        //    //await using Stream stream = file.OpenReadStream();

        //    return true;
        //    // We can now work with standard stream functionality of .NET
        //    // to handle the file.
        //}

        //public static IFormFile GetFile(this IResolverContext ctx, NameString name)
        //{
        //    var contextAccessor = ctx.Service<IHttpContextAccessor>();
        //    return contextAccessor.HttpContext.Request.Form.Files[name.Value];
        //}


    }




}
