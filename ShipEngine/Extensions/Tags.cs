namespace ShipEngine.Extensions {
  public static class TagExtensions
  {
    public static string CreateTag(this ShipEngine shipEngine)
    {
      return shipEngine.Tags.Create("foo");
    }
    public static string CreateTag(this ShipEngine shipEngine, string tag)
    {
      return shipEngine.Tags.Create(tag);
    }
  }
}