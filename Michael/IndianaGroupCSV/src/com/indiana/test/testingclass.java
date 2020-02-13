package com.indiana.test;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.maps.GeoApiContext;
import com.google.maps.GeocodingApi;
import com.google.maps.errors.ApiException;
import com.google.maps.model.GeocodingResult;
import com.indiana.SystemKey;

import java.io.IOException;

public class testingclass {
    GeoApiContext context;
    public void test(){
        try {
            context = new GeoApiContext.Builder()
                    .apiKey(SystemKey.Key)
                    .build();
            GeocodingResult[] results =  GeocodingApi.geocode(context,
                    "1600 Amphitheatre Parkway Mountain View, CA 94043").await();
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            System.out.println(gson.toJson(results[0].geometry.location.lat));
            System.out.println(gson.toJson(results[0].geometry.location.lng));
        } catch (ApiException ex) {
            System.out.println(ex.getMessage());
        } catch (InterruptedException ex) {
            System.out.println(ex.getMessage());
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }
}
