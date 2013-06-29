using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace Des
{
    class Program
    {
        public static string imagesFolder = "\\Images";
        public static string AudioFolder = "\\Audio";
        public static string videoFolder = "\\Video";
        public static string documentsFolder = "\\Documents";
        public static string compressedFolder = "\\Compressed Files";
        public static string shortCutsFolder = "\\Shortcuts";
        public static string otherFolder = "\\Other";
        public static string excuatablesFolder = "\\Applications files";
        public static string programmingFolder = "\\Programming Language Files";
        public static string designAndArchi = "\\design&archi";
        public static string currentDir = Directory.GetCurrentDirectory();
        public static string currentProcesss = Process.GetCurrentProcess().ProcessName;
        static void Main(string[] args)
        {


            //Console.WriteLine(currentProcesss);

            String[] directories = Directory.GetDirectories(currentDir);
            //folders to copt into.
            imagesFolder = currentDir + imagesFolder;
            compressedFolder = currentDir + compressedFolder;
            designAndArchi = currentDir + designAndArchi;
            AudioFolder = currentDir + AudioFolder;
            videoFolder = currentDir + videoFolder;
            documentsFolder = currentDir + documentsFolder;
            shortCutsFolder = currentDir + shortCutsFolder;
            otherFolder = currentDir + otherFolder;
            excuatablesFolder = currentDir + excuatablesFolder;
            programmingFolder = currentDir + programmingFolder;

            string now = DateTime.Now.ToShortTimeString().Replace(":", "_").Replace(" ", "_") + DateTime.Now.ToShortDateString().Replace("/", "_").Replace(" ", "_");
            directories = Directory.GetDirectories(currentDir);
            String[] fileList = Directory.GetFiles(currentDir);

            #region Image_Files
            string f;
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\"));
                f = f.ToLower();
                if (f.Contains(".png") || f.Contains(".jpg") || f.Contains(".bmp") || f.Contains(".ico") || f.Contains(".jpeg") || f.Contains(".gif") || f.Contains(".tiff") || f.Contains(".raw"))
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Images") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Images");
                        directories = Directory.GetDirectories(currentDir);

                    }
                   // File.Move(currentDir + f, imagesFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, imagesFolder, f);
                }

            }
            #endregion Image_Files

            fileList = Directory.GetFiles(currentDir);
            #region Audio_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); 
                f = f.ToLower();
                if (f.Contains(".mp3") || f.Contains(".rm") || f.Contains(".aac") || f.Contains(".wav") || f.Contains(".wma") || f.Contains(".ogg") || f.Contains(".m4a") || f.Contains(".ram") || f.Contains(".mp2"))
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Audio") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Audio");
                    } 
                    directories = Directory.GetDirectories(currentDir);
                   // File.Move(currentDir + f, AudioFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, AudioFolder, f);
                }
            }
            #endregion Audio_Files

            fileList = Directory.GetFiles(currentDir);
            #region Video_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Contains(".flv") || f.Contains(".wmv")
                    || f.Contains(".rmvb") || f.Contains(".mp4")
                    || f.Contains(".avi") || f.Contains(".mov")
                    || f.Contains(".mpeg") || f.Contains(".mpg")
                    || f.Contains(".mpe"))
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Video") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Video");
                    } directories = Directory.GetDirectories(currentDir);
                   // File.Move(currentDir + f, videoFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, videoFolder, f);
                }
            }
            #endregion video_Files

            fileList = Directory.GetFiles(currentDir);
            #region doc_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Contains(".doc")    || f.Contains(".pdf")
                    || f.Contains(".dot") || f.Contains(".csv")
                    || f.Contains(".gdoc")|| f.Contains(".xml")
                    || f.Contains(".txt")
                    || f.Contains(".rtf") || f.Contains(".xls")
                    || f.Contains(".gdoc")|| f.Contains(".xlk")
                    || f.Contains(".ppt") || f.Contains(".pez")
                    || f.Contains(".odp") || f.Contains(".pps")
                    || f.Contains(".sxi") || f.Contains(".vsd")
                    || f.Contains(".vsd") || f.Contains(".sdr"))
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Documents") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Documents");
                    } directories = Directory.GetDirectories(currentDir);
                   // File.Move(currentDir + f, documentsFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, documentsFolder, f);
                }
            }
            #endregion doc_Files

            fileList = Directory.GetFiles(currentDir);
            #region compressed_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Contains(".rar") || f.Contains(".tar")
                    || f.Contains(".gz") || f.Contains(".7z")
                    || f.Contains(".zip") || f.Contains(".lz"))
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Compressed Files") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Compressed Files");
                    } directories = Directory.GetDirectories(currentDir);
                   // File.Move(currentDir + f, compressedFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, compressedFolder, f);
                }

            }
            #endregion compressed_Files

            fileList = Directory.GetFiles(currentDir);
            #region shortCuts_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.ToLower().Contains(".lnk") || f.Contains(".LNK")
                    )
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Shortcuts") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Shortcuts");
                    } directories = Directory.GetDirectories(currentDir);
                    //File.Move(currentDir + f, shortCutsFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, shortCutsFolder, f);

                }
            }
            #endregion ShortCuts_Files

            fileList = Directory.GetFiles(currentDir);
            #region designAndArchi_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Contains(".dwf") || f.Contains(".dxf")
                    || f.Contains(".iam") || f.Contains(".drw")
                    || f.Contains(".ipn") || f.Contains(".icd")
                    || f.Contains(".ipt") || f.Contains(".rvt")
                    || f.Contains(".max") || f.Contains(".fbx")
                    || f.Contains(".blend") || f.Contains(".block")
                    || f.Contains(".psb") || f.Contains(".psd")
                    || f.Contains(".pdd") || f.Contains(".xcf")
                    || f.Contains(".bak") || f.Contains(".dw")
                    || f.Contains(".ai") || f.Contains(".eps")
                    || f.Contains(".lps"))
                {
                    if (Array.BinarySearch(directories, currentDir + "\\design&archi") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\design&archi");
                    } directories = Directory.GetDirectories(currentDir);
                  //  File.Move(currentDir + f, designAndArchi + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, designAndArchi, f);
                }
            }
            #endregion designAndArchi_Files


            fileList = Directory.GetFiles(currentDir);
            #region applications_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Replace("\\", "_") == currentProcesss.ToLower() || f.Contains(currentProcesss.ToLower())) continue;
                if (f.Contains(".exe") || f.Contains(".out")
                    || f.Contains(".jar") || f.Contains(".war")
                    )
                {
                    directories = Directory.GetDirectories(currentDir);
                    if (Array.BinarySearch(directories, currentDir + "\\Applications files") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Applications files");

                    }
                    //File.Move(currentDir + f, excuatablesFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, excuatablesFolder, f);
                }
            }
            #endregion applications_Files


            fileList = Directory.GetFiles(currentDir);
            #region programming_files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Contains(".java") || f.Contains(".cpp")
                    || f.Contains(".cs") || f.Contains(".h")
                    || f.Contains(".hpp") || f.Contains(".py")
                    || f.Contains(".js") || f.Contains(".css")
                    || f.Contains(".php") || f.Contains(".asm")
                    || f.Contains(".c") || f.Contains(".cxx")
                    || f.Contains(".pl") || f.Contains(".m")
                    || f.Contains(".lua") || f.Contains(".asp")
                    || f.Contains(".html") || f.Contains(".vhd")
                    || f.Contains(".xhtml") || f.Contains(".sql")
                    )
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Programming Language Files") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Programming Language Files");
                        directories = Directory.GetDirectories(currentDir);
                    }
                    //File.Move(currentDir + f, programmingFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, programmingFolder, f);
                }
            }
            #endregion programming_files

            fileList = Directory.GetFiles(currentDir);
            #region other_Files
            foreach (string t in fileList)
            {
                f = t.Substring(t.LastIndexOf("\\")); f = f.ToLower();
                if (f.Replace("\\", "_") == currentProcesss.ToLower() || f.Contains(currentProcesss.ToLower())) continue;
                {
                    if (Array.BinarySearch(directories, currentDir + "\\Other") < 0)
                    { //createDir{}
                        Directory.CreateDirectory(currentDir + "\\Other");
                    } directories = Directory.GetDirectories(currentDir);
                    // f.Substring(0,f.LastIndexOf("."));
                    //File.Move(currentDir + f, otherFolder + "\\" + now + f.Replace("\\", "_"));
                    insert(currentDir, otherFolder, f);
                }
            }
            #endregion other_Files

            #region WritengResults
            Console.WriteLine(@"
Developed by Moath Omar 2013
note : 
image files are directed to 
{0}, 

audio files are directed to 
{1},

movies & vedio files are directed to 
{2}, 

document files are directed to 
{3},

compressed files are directed to 
{4}, 

application files are directed to 
{5},

programming languages source code files are directed to 
{6}, 

shortcuts files are directed to 
{7}
othrer are directed to other folder", imagesFolder, AudioFolder, videoFolder,
                                                    documentsFolder, compressedFolder, excuatablesFolder,
                                                    programmingFolder, shortCutsFolder
                                                    );
            Console.WriteLine(" presss any key to exit");
            Console.Read();
            #endregion WritengResults
        }

        public static void insert(String src, String dst, String fileName)
        {
            String[] files = Directory.GetFiles(dst);
            int i = 1;
            int dotIndex  =fileName.LastIndexOf(".") ;
            if (dotIndex == -1)
                dotIndex = fileName.Length - 1;
            string absoluteName = fileName.Substring(0,dotIndex);
            string extension = fileName.Substring(dotIndex);
            string tmpName = fileName;
            while (File.Exists(dst + "\\" + tmpName)) {
                absoluteName = fileName.Substring(0, dotIndex);
                absoluteName = absoluteName +" " +i;
                tmpName = absoluteName + extension;
                i++; 
                Console.WriteLine("new name is {0}", tmpName);
            }
            File.Move(src + "\\" + fileName, dst + "\\" + tmpName);            
        }   
    }
}
