using System.Collections.Generic;
using Quests;

namespace BeastHunter
{
    public interface ISaveFileWrapper
    {
        #region Methods

        void CreateNewSave(string file);
        void LoadSave(string file);
        IEnumerable<int> GetCompletedQuests();
        Dictionary<int, int> GetActiveQuests();
        Dictionary<int, int> GetActiveObjectives();
        void SaveQuestLog(IEnumerable<Quest> quests, List<int> completeQuests);
        int GetNextItemEntry();
        void AddSaveData(string key, string value);
        void AddSaveData(KeyValuePair<string, string> param);

        #endregion
    }
}