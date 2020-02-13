/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package funnyselenium;
import java.util.List;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.maps.GeoApiContext;
import com.google.maps.GeocodingApi;
import com.google.maps.errors.ApiException;
import com.google.maps.model.GeocodingResult;

import java.io.IOException;
/**
 *
 * @author shatt
 */
public class FunnySelenium {
    public static WebDriver driver;
    public static void main(String[] args) {
        System.setProperty("webdriver.chrome.driver", "D:\\Selenium\\chromeDriver\\chromedriver.exe");
        System.out.println("Test Iniatiated");
        driver = new ChromeDriver();
        driver.get("https://li-public.fmcsa.dot.gov/LIVIEW/pkg_oos_process.prc_list?pv_vpath=LIVIEW&pv_show_all=N&pn_dotno=&pn_docket=&pv_legalname=&s_state=INUS");
        WebElement simpleTable = driver.findElement(By.xpath("/html/body/font/table[2]/tbody")); 
        // Get all rows 
        List<WebElement> rows = simpleTable.findElements(By.tagName("tr")); 
        //Variables
        StringBuilder data = new StringBuilder();
        StringBuilder data2 = new StringBuilder();
        String ID = "";
        String LegalName = "";
        String Address = "";
        String OOSReason = "";
        String OOSDate = "";
        String Status = "";
        String Geolocation = "";
        String DBAName = "";
        int count = 0;
        //runs through the rows
        for (WebElement row : rows) { 
            List<WebElement> cols = row.findElements(By.tagName("td"));
            List<WebElement> cols2 = row.findElements(By.tagName("th"));
            //collects data from columns
            for (WebElement col : cols) {
                data.append(col.getText() + "\t");
            }
            for (WebElement col2 : cols2) {
                data2.append(col2.getText() + "\t");
            }
            String[] array = data.toString().split("\t", 5);
            String[] array2 = data2.toString().replaceAll("\n", "").split("\t");
            //ignores row 1
            if(array.length > 1 && array2.length <=1){
                //separates data into separate variables
                ID = (array2[0].replaceAll("\t", "").replaceAll(" ", ""));
                String[] array3 = (array[0].replaceAll("\t", "").split("\n"));
                LegalName = array3[0];
                if(array3[1].equals(" ")){
                    DBAName = array3[1].replace(" ", "");
                }
                else{
                    DBAName = array3[1];
                }
                Address = (array[1].replaceAll("\t", "").replaceAll("\n", ""));
                OOSReason = (array[2].replaceAll("\t", "").replaceAll("\n", ""));
                OOSDate = (array[3].replaceAll("\t", "").replaceAll("\n", ""));
                Status = (array[4].replaceAll("\t", "").replaceAll("\n", ""));
                //geocodes the addresses
                //commented out so that credits are not wasted
                /*GeoApiContext context;
                GoogleKey k = new GoogleKey();
                try {
                    context = new GeoApiContext.Builder()
                            .apiKey(k.Key)
                            .build();
                    GeocodingResult[] results =  GeocodingApi.geocode(context, Address).await();
                    Gson gson = new GsonBuilder().setPrettyPrinting().create();
                    Geolocation = gson.toJson(results[0].geometry.location.lat) + ":" + gson.toJson(results[0].geometry.location.lng);
                } catch (ApiException | InterruptedException | IOException ex) {
                    System.out.println(ex.getMessage());
                }*/
                //prints data
                System.out.print(ID + " | " + LegalName + " |" + DBAName + "| " + Address + " | " + OOSReason + " | " + OOSDate + " | " + Status + " | " + Geolocation + " | ");
                count++;
            }
            System.out.println();
            data = null;
            data2 = null;
            data = new StringBuilder();
            data2 = new StringBuilder();
        }
        //for testing a single line
        //System.out.print(var + " | " + var1 + " | " + var2 + " | " + var3 + " | " + var4 + " | " + var5 + " | ");
        System.out.println(count);
        driver.close();
    }
    
}
