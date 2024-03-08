using CheckFile;



PrintMessage.Print("some message", new MySerialization().SerializeTo(new JsonReader().Read()));