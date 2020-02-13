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
        String pathToCsv = "F:\\IndianaGroup\\Indiana-Group\\Michael\\indiana.csv";
        String outputLocation = "F:\\IndianaGroup\\Indiana-Group\\Michael\\IndianaGroupCSV\\";
        truckingComp.TruckingMainWindowsConsole(pathToCsv,outputLocation,-1);

    }
    
}
