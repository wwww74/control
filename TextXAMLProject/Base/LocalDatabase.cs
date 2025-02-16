using System.Collections.Generic;
using System.Linq;
using TextXAMLProject.Model;

namespace TextXAMLProject.Base
{
    public class LocalDatabase
    {
        private static LocalDatabase _instance = new LocalDatabase();
        private List<HistoryItemModel> _historyItems;
        public static LocalDatabase Instance => _instance;
        private LocalDatabase() => _historyItems = new List<HistoryItemModel>();
        public List<HistoryItemModel> GetAllHistoryItems() => _historyItems;
        public HistoryItemModel GetHistoryItemById(int id) => _historyItems.FirstOrDefault(item => item.Id == id);
        public int GetHistoryItemCount() => _historyItems.Count;
        public void AddHistoryItem(HistoryItemModel newItem) => _historyItems.Add(newItem);
        public void RemoveHistoryItem() => _historyItems.Clear();
    }
}
