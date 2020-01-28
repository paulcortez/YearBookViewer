using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace YearBookViewer.DataObj
{
    public class AppSetting
    {
        [BsonId]
        public string Key { get; set; }
        public object Value { get; set; }

        private static string DataLocation = Properties.Settings.Default.SettingsFileName;
        private static string CollectionName = "appSettings";

        // Setting KEYS
        public enum SettingKeys {SOURCEDOCUMENTLOCATION, OTHERS}


        public static AppSetting GetSettingsByKey(string key)
        {
            AppSetting appSetting = new AppSetting();

            using (var db = new LiteDatabase(DataLocation))
            {
                var col = db.GetCollection<AppSetting>(CollectionName);

                appSetting = col.FindById(key);
            }

            return appSetting;
        }


        public static bool InsertUpdateSettings(AppSetting appSetting)
        {
            bool isSuccess = false;

            using (var db = new LiteDatabase(DataLocation))
            {
                var col = db.GetCollection<AppSetting>(CollectionName);

                try
                {
                    col.Upsert(appSetting);
                    isSuccess = true;
                }
                catch (Exception) { }
            }

            return isSuccess;
        }
    }
}
