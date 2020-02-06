/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.test;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.maps.GeoApiContext;
import com.google.maps.GeocodingApi;
import com.google.maps.errors.ApiException;
import com.google.maps.model.GeocodingResult;

import java.io.IOException;


/**
 *
 * @author Owner
 */
public class Test {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            GeoApiContext context = new GeoApiContext.Builder()
                    .apiKey("AIzaSyAtC2heFs_RhrAb4mMj3qYtG4oGJReU6FE")
                    .build();
            GeocodingResult[] results =  GeocodingApi.geocode(context,
                    "1600 Amphitheatre Parkway Mountain View, CA 94043").await();
            Gson gson = new GsonBuilder().setPrettyPrinting().create();
            System.out.println(gson.toJson(results[0].addressComponents));
        } catch (ApiException ex) {
            System.out.println(ex.getMessage());
        } catch (InterruptedException ex) {
            System.out.println(ex.getMessage());
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }
    
}
