   M S B A M L   `   `   `  ����A  =Nomina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NominaNomina  5   	   *    $Nomina.w_Liquidacion_Mensual_Detalle   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Nomina     5   	   -   5           MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5	       � Title$# w_Liquidacion_Mensual_Detalle��5   	   $	��450��6/   $	��800��6<   .��5      �� .+�5   
   �� $��Empleados Existentes��6   $	��359��61   $	��380��6>   
 �� Top$ 17��6J    �� Left$ 10��6Z   6o   �� 5   
   -   5         ��Name$ lblliquidacion��5      $��Liquidación:��6(   $ 93��6?   $ 82��6P   $��18(�6`   �� 5   
   -   5         ��Name$ cboLiquidacion��5      $	 242��6+   $ 82��6=   $	��120��6M   �� 5   
   -   5        $ label1��5      $��	Empleado:��6    $ 93��64   $	 139��6E   $��18(�6V   �� 5   
   -   5        $ cboEmpleado��5      $	 242��6(   $	 143��6:   $	��120��6K   �� 5   
   -   5        $ label2��5      $��	Concepto:��6    $ 93��64   $	 214��6E   $��18(�6V   �� 5   
   -   5        $ cboConcepto��5      $	 242��6(   $	 218��6:   $	��120��6K   �� 5   
   -   5        $ label3��5      $��Monto:��6    $ 93��61   $	 289��6B   $��18(�6S   �� 5   
   -	   5         ��Name$ txtMonto��5      $��23��6$   $	 242��60    �� TextWrapping$
 Wrap=�6B   $�� ��6V   $	 298��6^   $	��120��6o   �� 5   
   $��Empleados Existentes��6   $	 395��61   $ 17��6C   $	��387��6S   $	��359��6_   .��5      &   System.Windows.Controls.DataGrid  -
   5        $��dgConceptosLiquidacion��5      6_   5       �� 5!   
   -   5        	 ��Name$	 
btnAgregar��5!      $��Agregar��6%   $ 43��6P   $	 383��6a   $��90��6r   �� 5"   
   -   5        $	 btnmodificar��5"      $��	Modificar��6'   $��34��6V   $	 179��6b   $	 383��6t   $	��105��6�   �� 5#   
   -   5        $	 btneliminar��5#      $��Eliminar��6&   $��34��6S   $	 328��6_   $	 381��6q   $��95��6�   5$      5%      