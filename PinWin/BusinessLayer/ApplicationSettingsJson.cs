namespace PinWin.BusinessLayer
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    public static class ApplicationSettingsJson
    {
        private const string SettingsFilename = "settings.json";
        private const string SettingsFolder = "PinWin";

        public static bool SaveToFile(ApplicationSettings settings, string fileName = SettingsFilename)
        {
            var fileInfo = GetSettingsFile(fileName, true);

            try
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented, new JsonKeysConverter());
                Directory.CreateDirectory(fileInfo.Directory.FullName);
                File.WriteAllText(fileInfo.FullName, json);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static ApplicationSettings LoadFromFile(string fileName = SettingsFilename)
        {
            var fileInfo = GetSettingsFile(fileName);

            try
            {
                var settingsContents = File.ReadAllText(fileInfo.FullName);
                return JsonConvert.DeserializeObject<ApplicationSettings>(settingsContents, new JsonKeysConverter());
            }
            catch (Exception ex) when (ex is IOException || ex is JsonSerializationException)
            {
                //return default instance of application settings
                return new ApplicationSettings();
            }
        }

        private static FileInfo GetSettingsFile(string fileName = SettingsFilename, bool forSave = false)
        {
            var fileInfo = new FileInfo(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                SettingsFolder, fileName));

            if (forSave || fileInfo.Exists)
            {
                // load from the current folder
                return fileInfo;
            }

            return new FileInfo(fileName);
        }
    }
}