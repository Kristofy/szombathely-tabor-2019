using Newtonsoft.Json;
using System.IO;

public static class JSONHelper
{

    #region Public Methods

    public static void SaveJSONFile<T>(string path, T data) where T : class
    {
        string content = ToSerializedString(data);
        if (!string.IsNullOrWhiteSpace(content))
            try { File.WriteAllText(path, content); } catch { }
    }
    public static T LoadJSONFile<T>(string path) where T : class
    {
        try
        {
            if (File.Exists(path))
                return FromSerializedString<T>(File.ReadAllText(path));
        }
        catch { return default(T); }

        return default(T);
    }

    public static string ToSerializedString<T>(T data) where T : class
    {
        try
        {
            if (data == null) return "";
            return JsonConvert.SerializeObject(data);
        }
        catch
        {
            return "";
        }
    }
    public static T FromSerializedString<T>(string data) where T : class
    {
        try
        {
            if (string.IsNullOrEmpty(data)) return default(T);
            return JsonConvert.DeserializeObject<T>(data);
        }
        catch
        {
            return default(T);
        }
    }

    #endregion

}