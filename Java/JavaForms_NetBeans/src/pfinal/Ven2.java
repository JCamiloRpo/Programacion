package pfinal;
import java.io.*;
import javax.swing.*;
import org.jfree.chart.*;
import org.jfree.chart.plot.*;
import org.jfree.data.category.*;
import javax.swing.table.*;
/**
 *
 * @author Camilo
 */
public class Ven2 extends javax.swing.JFrame {

    public Ven2(){
        initComponents();
        TBM = (DefaultTableModel)TB_Ventas.getModel();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel2 = new javax.swing.JPanel();
        Tx_Cantidad = new javax.swing.JTextField();
        B_Aceptar = new javax.swing.JButton();
        CB_Tanque = new javax.swing.JComboBox<>();
        B_Acabar = new javax.swing.JButton();
        Graficar_1 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        L_Dia = new javax.swing.JLabel();
        jPanel4 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        TB_Ventas = new javax.swing.JTable();
        B_Confirmar = new javax.swing.JButton();
        B_Reabastecer = new javax.swing.JButton();
        B_Eliminar = new javax.swing.JButton();
        B_Cancelar = new javax.swing.JButton();
        B_Mostrar = new javax.swing.JButton();
        B_Fin = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);

        Tx_Cantidad.setText("0");

        B_Aceptar.setText("Aceptar");
        B_Aceptar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_AceptarActionPerformed(evt);
            }
        });

        CB_Tanque.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "--Seleccione tanque--", "Tanque 1", "Tanque 2", "Tanque 3", "Tanque 4", "Tanque 5", "Tanque 6", "Tanque 7", "Tanque 8", "Tanque 9" }));

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(88, 88, 88)
                .addComponent(CB_Tanque, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(67, 67, 67)
                .addComponent(Tx_Cantidad, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(41, 41, 41)
                .addComponent(B_Aceptar)
                .addContainerGap(99, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(Tx_Cantidad, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(B_Aceptar)
                    .addComponent(CB_Tanque, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(0, 12, Short.MAX_VALUE))
        );

        B_Acabar.setText("Acabar día");
        B_Acabar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_AcabarActionPerformed(evt);
            }
        });

        Graficar_1.setBackground(new java.awt.Color(0, 0, 255));
        Graficar_1.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 0, 0), 1, true));

        javax.swing.GroupLayout Graficar_1Layout = new javax.swing.GroupLayout(Graficar_1);
        Graficar_1.setLayout(Graficar_1Layout);
        Graficar_1Layout.setHorizontalGroup(
            Graficar_1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        Graficar_1Layout.setVerticalGroup(
            Graficar_1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 190, Short.MAX_VALUE)
        );

        jLabel9.setText("Día");

        L_Dia.setText("0");

        TB_Ventas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Tanque", "Cantidad"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        TB_Ventas.setGridColor(new java.awt.Color(128, 128, 218));
        jScrollPane1.setViewportView(TB_Ventas);
        if (TB_Ventas.getColumnModel().getColumnCount() > 0) {
            TB_Ventas.getColumnModel().getColumn(0).setResizable(false);
            TB_Ventas.getColumnModel().getColumn(1).setResizable(false);
        }

        B_Confirmar.setText("Confirmar compra");
        B_Confirmar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_ConfirmarActionPerformed(evt);
            }
        });

        B_Reabastecer.setText("Reabastecer tanques");
        B_Reabastecer.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_ReabastecerActionPerformed(evt);
            }
        });

        B_Eliminar.setText("Eliminar item");
        B_Eliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_EliminarActionPerformed(evt);
            }
        });

        B_Cancelar.setText("Cancelar compra");
        B_Cancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_CancelarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(160, 160, 160)
                .addComponent(B_Cancelar)
                .addGap(36, 36, 36)
                .addComponent(B_Eliminar)
                .addGap(30, 30, 30)
                .addComponent(B_Confirmar)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addContainerGap(127, Short.MAX_VALUE)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                        .addComponent(B_Reabastecer)
                        .addContainerGap())
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(141, 141, 141))))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 123, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(B_Confirmar)
                            .addComponent(B_Eliminar)
                            .addComponent(B_Cancelar))
                        .addContainerGap(38, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(B_Reabastecer))))
        );

        B_Mostrar.setText("Mostrar tanques");
        B_Mostrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_MostrarActionPerformed(evt);
            }
        });

        B_Fin.setText("Finalizar programa");
        B_Fin.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                B_FinActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(B_Fin)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(B_Acabar)
                .addContainerGap())
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(B_Mostrar)
                .addGap(25, 25, 25))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel9)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(L_Dia, javax.swing.GroupLayout.PREFERRED_SIZE, 17, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(53, 53, 53)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(39, Short.MAX_VALUE))
            .addComponent(Graficar_1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel9)
                    .addComponent(L_Dia))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(Graficar_1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(B_Mostrar)
                .addGap(3, 3, 3)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(B_Acabar, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap())
                    .addComponent(B_Fin, javax.swing.GroupLayout.Alignment.TRAILING)))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void B_AceptarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_AceptarActionPerformed
        int i,j;
        double aux=0d, aux1=0d;
        boolean f=true;
        try{
            if(Tx_Cantidad.getText().equals("0") || Tx_Cantidad.getText().isEmpty() || (CB_Tanque.getSelectedIndex()==0))
                JOptionPane.showMessageDialog(null,"No se puede agregar la venta a la tabla, revise los datos.");
            else {
                i=CB_Tanque.getSelectedIndex();
                j=TB_Ventas.getRowCount();
                aux1 = Double.parseDouble(Tx_Cantidad.getText());
                aux = (double)Vsus[i-1];
                while(f){
                    if(j >0 && TB_Ventas.getValueAt(j-1,0).toString().equals("Tanque "+String.valueOf(i))){
                        aux1 += Double.parseDouble(TB_Ventas.getValueAt(j-1,1).toString());
                        j --;
                    }
                    else{
                        aux -= aux1;
                        f=false;
                    }
                }
                if(aux>=25125){
                    Vdatos[0]=CB_Tanque.getSelectedItem();
                    Vdatos[1]=Tx_Cantidad.getText();
                    TBM.addRow(Vdatos);
                    Tx_Cantidad.setText("0");
                    CB_Tanque.setSelectedIndex(0);
                }
                else JOptionPane.showMessageDialog(null,"No se puede comprar esa cantidad del tanque\n, porque queda por debajo del minimo.");
            }
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error del boton aceptar es:"+ e);
        }
    }//GEN-LAST:event_B_AceptarActionPerformed

    private void B_ConfirmarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_ConfirmarActionPerformed
        int j,i;
        boolean f=true;
        try{
            Final.Es_arc = new FileWriter("C:/Users/Camilo/Documents/Ventas y Compras.txt",true);
            Final.Es_lin = new PrintWriter(Final.Es_arc);
            if(TB_Ventas.getRowCount()==0)JOptionPane.showMessageDialog(null,"No se puede confirmar la compra.");
            else{
                c ++;
                if(Final.dia<=10) Final.Es_lin.println("  Reporte de venta numero "+c);
                j=0;
                i=TB_Ventas.getRowCount()-1;
                while(f){
                    j ++;
                    if(TB_Ventas.getValueAt(i,0).toString().equals("Tanque "+String.valueOf(j))){
                        if(Final.dia<=10)
                            Final.Es_lin.println("      Del "+TB_Ventas.getValueAt(i,0).toString()+" se vendió: "+TB_Ventas.getValueAt(i,1).toString());
                        Vsus[j-1]=(double)Vsus[j-1]-Double.parseDouble(TB_Ventas.getValueAt(i,1).toString());
                        TBM.removeRow(i);
                        j=0;
                        if(i==0)f=false;
                        else i--;
                    }
                }
                if(Final.dia<=10){
                    Final.Es_lin.println();
                    Final.Es_lin.println();
                }
                CB_Tanque.setSelectedIndex(0);
                Tx_Cantidad.setText("0");
                B_MostrarActionPerformed(evt);
                if((double)Vsus[0]==25125d && (double)Vsus[1]==25125d && (double)Vsus[2]==25125d && (double)Vsus[3]==25125d && (double)Vsus[4]==25125d 
                    && (double)Vsus[5]==25125d && (double)Vsus[6]==25125d && (double)Vsus[7]==25125d && (double)Vsus[8]==25125d){
                    JOptionPane.showMessageDialog(null,"De cada tanque solo queda la cantidad minima (25000), \n debe reabastecer");
                    B_ReabastecerActionPerformed(evt);
                }
                else {
                    for(i=0;i<9;i++){
                        if((double)Vsus[i]==25125d){
                            if(JOptionPane.showConfirmDialog(null,"Del tanque "+(i+1)+" solo queda la cantidad minima (25000), \n ¿desea reabastecer?")==JOptionPane.YES_OPTION)
                            B_ReabastecerActionPerformed(evt);
                        }
                    }
                }
            }
        }
        catch(IOException e){
            JOptionPane.showMessageDialog(null,"El error de apertura de la ventana 2 es "+e);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error del boton fin es:"+ e);
        }
        finally{
            try {
                Final.Es_lin.close();
            } catch (Exception e) {
                JOptionPane.showMessageDialog(null,"El error de cierre es "+e);
            }
        }
    }//GEN-LAST:event_B_ConfirmarActionPerformed

    private void B_ReabastecerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_ReabastecerActionPerformed
        try{
            for (int i=0;i<9; i++) {
                if(i>=0 && i<3)Vnec[i]=500000d -(double)Vsus[i];
                else if(i>=3 && i<7)Vnec[i]=550000d - (double)Vsus[i];
                else if(i>=7 && i<9)Vnec[i]=2800000d - (double)Vsus[i];
            }
            Ven3.TBM.addRow(Vnec);
            Final.ven3();
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error del boton reabastecer es:"+ e);
        }
    }//GEN-LAST:event_B_ReabastecerActionPerformed

    private void B_EliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_EliminarActionPerformed
        try {
            selec = TB_Ventas.getSelectedRow();
            if(selec != -1){
                if(JOptionPane.showConfirmDialog(null,"Esta seguro de eliminar?")==JOptionPane.YES_OPTION)
                    TBM.removeRow(selec);
            }
            else JOptionPane.showMessageDialog(null,"Debe seleccionar una fila, para poder eliminar");
        }
        catch (Exception e) {
            JOptionPane.showMessageDialog(null,"El error del boton eliminar es: "+e);
        }
    }//GEN-LAST:event_B_EliminarActionPerformed

    private void B_AcabarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_AcabarActionPerformed
        try{
            Final.Es_arc = new FileWriter("C:/Users/Camilo/Documents/Ventas y Compras.txt",true);
            Final.Es_lin = new PrintWriter(Final.Es_arc);
            if(Final.dia<=10){
                Final.Es_lin.println("  Total ventas: "+c);
                Final.Es_lin.println("  Total compras: "+Ven3.c);
                Final.Es_lin.println("  Contenido final de tanques");
                for (int i=0;i<9; i++) {
                    Final.Es_lin.println("      Tanque: "+(i+1)+" contiene: "+Ven2.Vsus[i]);
                }
                Final.Es_lin.println("Fin del día");
                Final.Es_lin.println("-----------------------------------------");
                Final.Es_lin.println();
            }
            Final.dia ++;
            Final.ven1();
        }
        catch(IOException e){
            JOptionPane.showMessageDialog(null,"El error de apertura de la ventana 2 es "+e);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error del boton cerrar es:"+ e);
        }
        finally{
            try {
                Final.Es_lin.close();
            } catch (Exception e) {
                JOptionPane.showMessageDialog(null,"El error de cierre de la ventana 2 es "+e);
            }
        }
    }//GEN-LAST:event_B_AcabarActionPerformed

    private void B_MostrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_MostrarActionPerformed
        try{
            for (int i=0;i<9;i++) {
                grafica.addValue((double)Vsus[i],String.valueOf(i+1),String.valueOf(i+1));
            }
            Graficar_1.add(mostrar);
            mostrar.setVisible(true);
            mostrar.setSize(Graficar_1.getWidth()-1,Graficar_1.getHeight()-1);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error de mostrar es:"+ e);
        }
    }//GEN-LAST:event_B_MostrarActionPerformed

    private void B_CancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_CancelarActionPerformed
        try{
            for(int i=TB_Ventas.getRowCount()-1;i>=0;i--) {
                TBM.removeRow(i);
            }
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error de cancelar es:"+ e);
        }
    }//GEN-LAST:event_B_CancelarActionPerformed

    private void B_FinActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_B_FinActionPerformed
        try{
            System.exit(0);
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null,"El error de cancelar es:"+ e);
        }
    }//GEN-LAST:event_B_FinActionPerformed

    public static DefaultCategoryDataset grafica = new DefaultCategoryDataset();
    public static JFreeChart tanques = ChartFactory.createBarChart3D("", "Tanque", "", grafica, PlotOrientation.VERTICAL, false, true, false);
    public static ChartPanel mostrar = new ChartPanel(tanques);
    int selec = -1, c = 0;
    DefaultTableModel TBM;
    public static Object[] Vdatos = new Object[2],Vsus = new Object[9], Vnec = new Object[9];
    
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton B_Acabar;
    private javax.swing.JButton B_Aceptar;
    private javax.swing.JButton B_Cancelar;
    private javax.swing.JButton B_Confirmar;
    private javax.swing.JButton B_Eliminar;
    private javax.swing.JButton B_Fin;
    private javax.swing.JButton B_Mostrar;
    private javax.swing.JButton B_Reabastecer;
    private javax.swing.JComboBox<String> CB_Tanque;
    public static javax.swing.JPanel Graficar_1;
    public static javax.swing.JLabel L_Dia;
    private javax.swing.JTable TB_Ventas;
    private javax.swing.JTextField Tx_Cantidad;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}