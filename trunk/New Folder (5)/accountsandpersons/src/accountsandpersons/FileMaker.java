/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package accountsandpersons;

/**
 *
 * @author J & J
 */

import java.util.*;

public class FileMaker {

    private Formatter x;

    public void openFile(){

        try{
            x = new Formatter("banksaving.txt");
        }catch (Exception e){
            System.out.println("you have an error");

        }
    }
public void addRecords(){
    //String booleanString = new Boolean(Account.resetted).toString();
    x.format("%s%s%s%s%s",Account.accountNum+' ', Account.balance+" ", Account.owner.getName()+' ', Account.freeTransCharge+" ", Account.resetted);

}
public void closeFile(){
    x.close();
}
}
