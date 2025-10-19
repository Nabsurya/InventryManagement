namespace InventryManageMent.Models
{
    public class User
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public byte[] PasswordHash { get; set; } = Array.Empty<byte>();

    public byte[] PasswordKey { get; set; } = Array.Empty<byte>();
}
}
