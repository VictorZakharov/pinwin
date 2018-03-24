using System;
using System.IO;
using Newtonsoft.Json;

namespace PinWin.BusinessLayer
{
    public static class ApplicationSettingsJson
    {
        private const string SettingsFilename = "settings.json";

        public static bool SaveToFile(ApplicationSettings settings, string fileName = SettingsFilename)
        {
            try
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented, new JsonKeysConverter());
                File.WriteAllText(fileName, json);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static ApplicationSettings LoadFromFile(string fileName = SettingsFilename)
        {
            try
            {
                var settingsContents = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<ApplicationSettings>(settingsContents, new JsonKeysConverter());
            }
            catch (Exception ex) when (ex is IOException || ex is JsonSerializationException)
            {
                //return default instance of application settings
                return new ApplicationSettings();
            }
        }
    }
}