using FunctionalCurry.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.HandOn
{
    public static class Demo
    {
        public static void Run()
        {

            var test = FinalFunctiona();

           var finalAns=   test("http://google.com");
        }

       

        public static  Result  DoHandsOn(string url, CloudStorageApiDetails cloudStorageApiDetails )
        {

            //valid url
            // download  html
            // convert to pdf
            // upload to cloud

            return default(Result);
        }


        public static Func<string ,Result> FinalFunctiona()
        {
            return (string input) =>
            {
                var validation = ValidUrl(input);
                var download = DownLoadHtml();
              return  download(validation);

            };
        }


        public static Func<Result<Uri>>  ValidUrl(string input )
        {
            return () =>
            {
                if (!string.IsNullOrEmpty(input))
                {
                    return Result.Ok<Uri>(new Uri(input));
                }
                else
                {
                    return Result.Fail<Uri>("Invalid File");
                }
            };
        }



        public static Func<Func<Result<Uri>>, Result<FileInfo>> DownLoadHtml()
        {

            return (Func <Result<Uri>> validation) =>
            {

                var validationResult = validation();

                if (validationResult.Failure)
                {
                    return Result.Fail<FileInfo>(validationResult.Error);
                }
                else
                {

                    try
                    {

                        using (var client = new HttpClient())
                        {
                            var html = client.GetStringAsync(validationResult.Value).Result;
                            var fileName = Path.Combine(Environment.CurrentDirectory, string.Concat(new Random().Next().ToString(), ".html"));
                            var downloadHtml = client.GetStringAsync(validationResult.Value).Result;
                            using (var writer = new StreamWriter(fileName, false, Encoding.Unicode))
                            {
                                writer.Write(downloadHtml);
                            }

                            return Result.Ok<FileInfo>(new FileInfo(fileName));

                        }

                    }
                    catch (Exception ex)
                    {
                        return Result.Fail<FileInfo>(ex.Message);
                    }
                }
            };


        }

        //public static Func<Result<FileInfo>>  ConvertToPdfFie(Result<FileInfo> htmlresult)
        //{

        //}

        public static Func<Result> UploadFile(Result<FileInfo> fileResult, CloudStorageApiDetails cloudStorageApiDetails)
        {
            if (fileResult.Failure)
            {
                return () => fileResult;
            }
            else
            {
                return () =>
                {
                    //// uplaod ///cloudStorageApiDetails

                    return Result.Ok("File Uploded succesfully");
                  r//eturn  uploadFun();
                };
            }
           
        }

    }
}
