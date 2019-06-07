using System.Collections.Generic;

namespace CyclicGraphDetectorBusinessLayer.Models
{
    public class CsvFileContent
    {
        public List<CsvEntry> CsvEntries { get; set; }
        public Dictionary<string,HashSet<WeightedChildNode>> ParentsWithChildrenAdjecencyList { get; set; }
    }
}