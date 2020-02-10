/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.indiana.csv;

import java.io.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Michael
 */
public class IndianaCSVconverter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        BufferedReader csvReader = null;
        SystemKey k = new SystemKey();
        truckingComp t = new truckingComp(k.Key, false);
        List<String> ErrorInserts = new ArrayList<String>();
        String outputLocation = "F:\\IndianaGroup\\Indiana-Group\\Michael\\IndianaGroupCSV\\";
        Connection con = null;
        try {
            String pathToCsv = "F:\\IndianaGroup\\Indiana-Group\\Michael\\indiana.csv";
            csvReader = new BufferedReader(new FileReader(pathToCsv));
            String row = csvReader.readLine();
            int f = 0;
            con = DriverManager.getConnection(k.azureConnectionString);
            while ((row = csvReader.readLine()) != null) {
                //System.out.println(row);
                t.csvRowDataSet(row, ",","update", f);
                String SQL = t.toSQLInsert();
                System.out.println(SQL);
                try {
                    Statement stml = con.createStatement();
                    stml.execute(SQL);
                } catch (SQLException ex) {
                    System.out.println(ex.getMessage());
                    ErrorInserts.add(SQL);
                }
                
                t.clearData();
                f++;
//                if(f>=1)
//                    break;
            }
        } catch (FileNotFoundException ex) {
        } catch (IOException ex) {
        } catch (SQLException e) {
            e.printStackTrace();
        } finally {
            try {
                csvReader.close();
                con.close();
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        }
        if(ErrorInserts.size() > 0){
            System.out.println("\n\n\n\n\n\n\n\n\n\n");

            DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM-dd-yyyy");
            LocalDate localDate = LocalDate.now();
            String file = outputLocation + dtf.format(localDate)+"_Error_List.sql";
            PrintWriter fileWriter = null;
            try {
                fileWriter = new PrintWriter(file);
                for(String insert : ErrorInserts) {
                    System.out.println(insert);
                    fileWriter.write(insert+"\n");
                }

                System.out.println("Outputting to sql file " + file);
                Runtime.getRuntime().exec("explorer.exe /select, "+file);
            } catch (IOException e) {
                e.printStackTrace();
            }finally {
                fileWriter.close();
            }

        }
    }
    
}
