   M S B A M L   `   `   `  ����J  FDesktopBaseTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DesktopBaseTask.ViewsDesktopBaseTask.Views  5      G(clr-namespace:DesktopBaseTask.ViewModelsDesktopBaseTask.ViewModels  69   (    "DesktopBaseTask.Views.ContactsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:DesktopBaseTask.Views     5      ?
viewmodels(clr-namespace:DesktopBaseTask.ViewModels     69   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6u     N� Title$  ContactsView��5	       � DataContext 5
      2   ,DesktopBaseTask.ViewModels.ContactsViewModel  5   
    � 	Resources 5         
OpenFilter �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value p� KeyTime p� Value  CloseFilter��%�  &	        &	 T    �� 5   
   .��5      U� $ (FrameworkElement.Height)�6,   $ 
GridFilter��6b   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.2��6'   $	 200Q�69   5      r� 5      $ (FrameworkElement.Margin)�6/   $ ButtonOpenFilter��6e   .	�5      �� $ 0��6*   $ 0, 0, 0, 10q�66   �� 5      $ 0:0:0.2��6*   $ 0, 0, 0, 210q�6<   5      r� 5      $ (FrameworkElement.Margin)�6/   $ ButtonCloseFilter��6e   .	�5      �� $ 0��6*   $ 0, 0, 0, 10q�66   �� 5      $ 0:0:0.2��6*   $ 0, 0, 0, 210q�6<   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Height)�6,   $ 
GridFilter��6b   .\�5        $ 0��6'   $	 200Q�63     5       $ 0:0:0.2��6'   $ 0Q�69   5!      r� 5"      $ (FrameworkElement.Margin)�6/   $ ButtonOpenFilter��6e   .	�5#      �� $ 0��6*   $ 0, 0, 0, 210q�66   �� 5$      $ 0:0:0.2��6*   $ 0, 0, 0, 10q�6<   5%      r� 5&      $ (FrameworkElement.Margin)�6/   $ ButtonCloseFilter��6e   .	�5'      �� $ 0��6*   $ 0, 0, 0, 210q�66   �� 5(      $ 0:0:0.2��6*   $ 0, 0, 0, 10q�6<   5)      5*      5+      	 � Triggers	 5,      :� 5-   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenFilter��66   .[�5.      �� #��[  6   5/      :� 50   
   $
 ButtonBase.Click��6   $ ButtonCloseFilter��66   .[�51      �� #��[ 6   52      .��55      � .+�56   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  ��6   �� *
Contacts+   Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$
 From��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *From+  59      $ To��6%    61   �� *To+  5:      $ 
Member1_ID��6%    69   �� *
Member1_ID+  5;      $ 
Member2_ID��6%    69   �� *
Member2_ID+5=      �� 5?   
   -   5         ��Name$ ButtonOpenFilter��5?       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6+   ���#443BED$��30��6�   $��30��6�   $��0, 0, 0, 10q�5@      $��Bottom=�6&   ��5?   q   Z� .��5A      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ArrowTop=�6&   $��20��66   $��20��6A   5B      �� 5C   
   -   5        $ ButtonCloseFilter��5C      #��[ 6,   ���#443BED$��30��6�   $��30��6�   $��0, 0, 0, 10q�5D      $��Bottom=�6&   $y�	Collapsed=�6A   ��5C   r   Z� .��5E        $ ArrowBottom=�6&   $��20��69   $��20��6D   5F      � 5H   
   -   5         �Name$ 
GridFilter��5H      $��Bottom=�6#   ���#3B8FED$��0��6S   .+�5I      � $��Center=�6   $��Center=�6.    � ColumnDefinitions 5J      �� 5K      �� 5L      �� 5M       � RowDefinitions 5O      �� 5P      �� 5Q      �� 5R      .+�5U      �� $%��Начало интервала��6   $��5q�63   $��Center=�6>   �� 5V      $#��Конец интервала��6   $��1��62   $��5q�6B   $��Center=�6M   �� 5W      $'��!Длительность (мин)��6   $��2��65   $��5q�6E   $��Center=�6P   (  "System.Windows.Controls.DatePicker  5X      $��1��6     5Y      $��1��6   $��1��6*   $��5q�6:   �� 5Z      $��1��6   $��2��6'   $��5q�67   $��Center=�6B   �� 5[      $��2��6   $��3��6*    �� Orientation$ 
Horizontal=�6>   $��Center=�6W   $��5q�6t   .+�5\      �� $ ��Отсортировать��6   $��5q�65   �� 5]      $#��Сбросить фильтр��6   $��5q�67   5^      5_      5`      5a      5b      