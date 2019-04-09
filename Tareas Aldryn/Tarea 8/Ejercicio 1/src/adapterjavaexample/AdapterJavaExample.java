/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package adapterjavaexample;

/**
 *
 * @author FEDERICO DIAZ
 */
public class AdapterJavaExample {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Adapter conversor = new Adapter();
        conversor.ingresarPesetas( 3000 );
        conversor.ingresarPesetas( 6000 );
        conversor.ingresarPesetas( 2000 );
        System.out.println( "Total euros: " + conversor.getTotalEuros() );
        
    }
    
}
