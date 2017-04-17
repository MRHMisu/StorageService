using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StorageService.Models;
using System.IO;
using StorageService.Services;

namespace StorageService.Services
{
    public class StorageRetrieveService : IStorageRetrieveService
    {

        private string _baseStoragePath = "~/FileStorage/";
        List<StorageFile> IStorageRetrieveService.GetFiles(string accessId, string baseUrl)
        {
            string path = HttpContext.Current.Server.MapPath(_baseStoragePath + accessId);
            string[] fileArray = Directory.GetFiles(path);
            List<StorageFile> _storageFiles = new List<StorageFile>();
            foreach (string filepath in fileArray)
            {
                FileInfo _fileInfo = new FileInfo(filepath);
                var _root = _fileInfo.Directory.Name;
                var _name = _fileInfo.Name;
                var _size = _fileInfo.Length;
                var _extention = _fileInfo.Extension;
                var _creationTime = _fileInfo.CreationTime.ToString();
                var _lastWriteTime = _fileInfo.LastWriteTime.ToString();
                var _lastAccessTime = _fileInfo.LastAccessTime.ToString();
                var root = HttpContext.Current.Server.MapPath("~");

                var _accessURL = HttpUtility.UrlPathEncode(baseUrl + "/" + _fileInfo.FullName.Replace(root, string.Empty).Replace("\\", "/"));
                StorageFile _storageFile = new StorageFile(_root, _name, _creationTime, _lastWriteTime, _lastAccessTime, _extention, _size, _accessURL);

                _storageFiles.Add(_storageFile);

            }
            return _storageFiles;
        }

        List<StorageDirectory> IStorageRetrieveService.GetDirectories(string accessId)
        {

            string path = HttpContext.Current.Server.MapPath(_baseStoragePath + accessId);
            string[] directoryArray = Directory.GetDirectories(path);

            List<StorageDirectory> _storageDirectories = new List<StorageDirectory>();

            foreach (var directorypath in directoryArray)
            {
                DirectoryInfo _directoryInfo = new DirectoryInfo(directorypath);
                var _root = _directoryInfo.Parent.Name;
                var _name = _directoryInfo.Name;
                var _creationTime = _directoryInfo.CreationTime.ToString();
                var _lastWriteTime = _directoryInfo.LastWriteTime.ToString();
                var _lastAccessTime = _directoryInfo.LastAccessTime.ToString();
                var _size = _directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
                var _numberOFFiles = _directoryInfo.GetFiles().Length;
                StorageDirectory _stroageDirectory = new StorageDirectory(_root, _name, _creationTime, _lastWriteTime, _lastAccessTime, _size, _numberOFFiles);
                _storageDirectories.Add(_stroageDirectory);
            }

            return _storageDirectories;


        }

        StorageFile IStorageRetrieveService.GetFileByName(string accessId, string name)
        {
            throw new NotImplementedException();
        }

        List<StorageFile> IStorageRetrieveService.GetFilesByExtention(string accessId, string extention)
        {
            throw new NotImplementedException();
        }

        StorageDirectory IStorageRetrieveService.GetDirectoryByName(string accessId, string name)
        {
            throw new NotImplementedException();
        }

        StorageDirectory IStorageRetrieveService.GetDirectoryWithFiles(string accessId, string name)
        {
            throw new NotImplementedException();
        }

        List<StorageDirectory> IStorageRetrieveService.GetDirectoriesWithFiles()
        {
            throw new NotImplementedException();
        }
    }
}