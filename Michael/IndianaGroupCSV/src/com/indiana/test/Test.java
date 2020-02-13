/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.test;

import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;


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
//        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM-dd-yyyy");
//        LocalDate localDate = LocalDate.now();
//        String s = dtf.format(localDate);
//        String file = "F:\\IndianaGroup\\Indiana-Group\\Michael\\IndianaGroupCSV\\"+String.format("%sMyFile.sql", s);
//        try {
//            PrintWriter  writer = new PrintWriter(file);
//            writer.write("Hello World\n");
//            writer.write("Good Bye!");
//            writer.close();
//            Runtime.getRuntime().exec("explorer.exe /select, " + file);
//        } catch (IOException e) {
//            e.printStackTrace();
//        }
        ScriptEngineManager manager = new ScriptEngineManager();
        ScriptEngine engine = manager.getEngineByName("javascript");

        try {
            engine.eval("var obj = JSON.parse('{ \"results\" : [ { \"address_components\" : [ { \"long_name\" : \"1600\", \"short_name\" : \"1600\", \"types\" : [ \"street_number\" ] }, { \"long_name\" : \"Amphitheatre Parkway\", \"short_name\" : \"Amphitheatre Pkwy\", \"types\" : [ \"route\" ] }, { \"long_name\" : \"Mountain View\", \"short_name\" : \"Mountain View\", \"types\" : [ \"locality\", \"political\" ] }, { \"long_name\" : \"Santa Clara County\", \"short_name\" : \"Santa Clara County\", \"types\" : [ \"administrative_area_level_2\", \"political\" ] }, { \"long_name\" : \"California\", \"short_name\" : \"CA\", \"types\" : [ \"administrative_area_level_1\", \"political\" ] }, { \"long_name\" : \"United States\", \"short_name\" : \"US\", \"types\" : [ \"country\", \"political\" ] }, { \"long_name\" : \"94043\", \"short_name\" : \"94043\", \"types\" : [ \"postal_code\" ] } ], \"formatted_address\" : \"1600 Amphitheatre Pkwy, Mountain View, CA 94043, USA\", \"geometry\" : { \"location\" : { \"lat\" : 37.4223112, \"lng\" : -122.0846428 }, \"location_type\" : \"ROOFTOP\", \"viewport\" : { \"northeast\" : { \"lat\" : 37.42366018029151, \"lng\" : -122.0832938197085 }, \"southwest\" : { \"lat\" : 37.42096221970851, \"lng\" : -122.0859917802915 } } }, \"place_id\" : \"ChIJtYuu0V25j4ARwu5e4wwRYgE\", \"plus_code\" : { \"compound_code\" : \"CWC8+W4 Mountain View, California, United States\", \"global_code\" : \"849VCWC8+W4\" }, \"types\" : [ \"street_address\" ] } ], \"status\" : \"OK\" }');");
            engine.eval("var s = obj.results[0].formatted_address;");
            String s = (String) engine.eval("s");
            System.out.println(s);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }


}
