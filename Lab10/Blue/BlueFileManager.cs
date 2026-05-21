namespace Lab10.Blue;

public abstract class BlueFileManager<T> : MyFileManager, ISerializer<T> where T : Lab9.Blue.Blue
{
    protected BlueFileManager(string name) : base(name)
    {
    }

    protected BlueFileManager(string name, string folderPath, string fileName, string fileExtension = "") : base(name, folderPath, fileName, fileExtension)
    {
    }

    public abstract void Serialize(T obj);

    public abstract T Deserialize();

    public override void EditFile(string text)
    {
        if (File.Exists(FullPath))
        {
            File.WriteAllText(FullPath, text);
        }
    }

    public override void ChangeFileExtension(string newExtension)
    {
        base.ChangeFileExtension(newExtension);
    }
}