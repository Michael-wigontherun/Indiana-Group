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

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;


/**
 *
 * @author Owner
 */
public class Test {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//        testingclass t = new testingclass();
//        t.test();
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM-dd-yyyy");
        LocalDate localDate = LocalDate.now();
        dtf.format(localDate);
        String file = "F:\\IndianaGroup\\Indiana-Group\\Michael\\IndianaGroupCSV\\"+String.format("%sMyFile.sql", dtf.format(localDate));
        try {
            PrintWriter  writer = new PrintWriter(file);
            writer.write("Hello World\n");
            writer.write("Good Bye!");
            writer.close();
            Runtime.getRuntime().exec("explorer.exe /select, " + file);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }


}
