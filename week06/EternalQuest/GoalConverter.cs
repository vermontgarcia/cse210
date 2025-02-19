using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalConverter : JsonConverter<Goal>
{
  public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
    {
      JsonElement root = doc.RootElement;

      if (!root.TryGetProperty("Type", out JsonElement typeElement))
        throw new JsonException("Missing 'Type' property for polymorphic deserialization.");

      string type = typeElement.GetString();

      return type switch
      {
        "SimpleGoal" => JsonSerializer.Deserialize<SimpleGoal>(root.GetRawText(), options),
        "EternalGoal" => JsonSerializer.Deserialize<EternalGoal>(root.GetRawText(), options),
        "ChecklistGoal" => JsonSerializer.Deserialize<ChecklistGoal>(root.GetRawText(), options),
        _ => throw new JsonException($"Unknown type: {type}")
      };
    }
  }

  public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();

    // Store the type for deserialization
    writer.WriteString("Type", value.GetType().Name);

    // Serialize the actual object
    string jsonString = JsonSerializer.Serialize(value, value.GetType(), options);
    using (JsonDocument doc = JsonDocument.Parse(jsonString))
    {
      foreach (var prop in doc.RootElement.EnumerateObject())
      {
        prop.WriteTo(writer);
      }
    }
    writer.WriteEndObject();
  }
}
