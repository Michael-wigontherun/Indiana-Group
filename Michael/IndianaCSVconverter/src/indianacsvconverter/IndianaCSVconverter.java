/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package indianacsvconverter;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Owner
 */
public class IndianaCSVconverter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        BufferedReader csvReader = null;
        try {
            String pathToCsv = "F:\\IndianaGroup\\Indiana-Group\\Michael\\indiana.csv";
            csvReader = new BufferedReader(new FileReader(pathToCsv));
            String row = csvReader.readLine();
            while ((row = csvReader.readLine()) != null) {
                String[] data = row.split(",");
                
                break;
            }   
            csvReader.close();
        } catch (FileNotFoundException ex) {
        } catch (IOException ex) {
        } finally {
            try {
                csvReader.close();
            } catch (IOException ex) {
            }
        }
        
    }
    
}
