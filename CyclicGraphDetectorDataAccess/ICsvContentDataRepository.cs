using System.Collections.Generic;

namespace CyclicGraphDetectorDataAccess
{
    public interface ICsvContentDataRepository
    {
       void Save(string fileName, byte[] contentBytes);
        List<CsvFile> GetFiles();
        CsvFile GetCsvFile(int id);
    }
}
