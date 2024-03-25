package com.example.communityplayer.json;

import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

import java.io.IOException;

public class JsonRequestTypeAdapter extends TypeAdapter<JsonRequest> {
    @Override
    public void write(JsonWriter out, JsonRequest request) throws IOException {
        out.beginObject();
        out.name("songId").value(request.songId);
        out.name("command").value(request.command);
        out.endObject();
    }

    @Override
    public JsonRequest read(JsonReader in) throws IOException {
        JsonRequest request = new JsonRequest();
        in.beginObject();
        while (in.hasNext()) {
            String name = in.nextName();
            if (name.equals("songId")) {
                request.songId = in.nextString();
            } else if (name.equals("command")) {
                request.command = in.nextString();
            } else {
                in.skipValue();
            }
        }
        in.endObject();
        return request;
    }
}
