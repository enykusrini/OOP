/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpleclient;

/**
 *
 * @author Erni Kusrini
 */
import java.io.*;
import java.net.*;

public class SimpleClient {

    /**
     * @param args the command line arguments
     */
    public final static int REMOTE_PORT = 5000;

    public static void main(String args[]) throws Exception {
        // TODO code application logic here
        Socket cl = null;
        BufferedReader is = null;
        DataOutputStream os = null;
        BufferedReader stdin = new BufferedReader(new InputStreamReader(System.in));
        String userInput = null;
        String output = null;
// Membuka koneksi ke server pada port REMOTE_PORT
        try {
            cl = new Socket("localhost", REMOTE_PORT);
            is = new BufferedReader(new InputStreamReader(cl.getInputStream()));
            os = new DataOutputStream(cl.getOutputStream());
        } catch (UnknownHostException e1) {
            System.out.println("Unknown Host: " + e1);
        } catch (IOException e2) {
            System.out.println("Erorr io: " + e2);
        }
// Menulis ke server
        while (output != "bye") {
            try {
                System.out.print("Masukkan kata kunci: ");
                userInput = stdin.readLine();
                os.writeBytes(userInput + "\n");
            } catch (IOException ex) {
                System.out.println("Error writing to server..." + ex);
            }
// Menerima tanggapan dari server
            try {
                output = is.readLine();
                System.out.println("Dari server: " + output);
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
// close input stream, output stream dan koneksi
        try {
            is.close();
            os.close();
            cl.close();
        } catch (IOException x) {
            System.out.println("Error writing...." + x);
        }
    }
}
