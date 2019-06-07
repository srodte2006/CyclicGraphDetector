using System.Collections.Generic;
using CyclicGraphDetectorBusinessLayer.Models;
using CyclicGraphDetectorBusinessLayer;
using CyclicGraphDetectorDataAccess;

namespace CyclicGraphDetectorBusinessLayer
{
    public interface ICsvUploadManager
    {
        void PersistUploadedCsvContent(string fileBaseFileName, byte[] contentBytes);
       // byte[] GetCsvContentBytes();
        List<CsvFile> GetFiles();
        CsvFile GetFile(int id);

    }
}