   M S B A M L   `   `   `  ���� J  FDesktopBaseTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DesktopBaseTask.ViewsDesktopBaseTask.Views  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity G(clr-namespace:DesktopBaseTask.ViewModelsDesktopBaseTask.ViewModels  $    DesktopBaseTask.Views.MainView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:DesktopBaseTask.Views     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  9
viewmodels(clr-namespace:DesktopBaseTask.ViewModels    � Title$  MainView��$	��600��$
��1080��
������� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=����#FFFFFF � DataContext .   (DesktopBaseTask.ViewModels.MainViewModel   � 	Resources    OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	CloseMenu��%�   &	        &	 q     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 70Q�  $ 0:0:0.2��$		 200Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$		 200Q�  $ 0:0:0.2��$	 70Q�
 � Triggers
 :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ ButtonOpenMenu��.[��� #��[  :� $ ButtonBase.Click��$ ButtonCloseMenu��.[��� #��[ .��� ���	#FFDEDEDE.+� � -     �Name$ 	FrameMain��$��Right=�$��Bottom=�$	��540��$
��1010��  � NavigationUIVisibility$ Hidden=����#FFFFFF���� *CurrentPage+ J� Opacity �� *FrameOpacity+� -    �Name$ 
HeadWindow��$��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+���  �� Orientation$ 
Horizontal=�$��Right=�$��5q�.+��� -    ��Name$ closeWindow��
���  ��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=��� $��Center=�$��Center=�$��22(� СтопКоронавирус� -   $ GridMenu��$��70��$
��Left=����	#FF31577E   $ 2Q�$ 1Q�$ 	#FFAEAEAE��.+��� .+�� $��60��
������� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� .+��� -   $ ButtonOpenMenu��$��60��$��60��$��5q�$
��Left=�$	��Top=� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ ���	#FF31577E��Z� ��Z� .��  $
 Menu=�$��25��$��25���� -   $ ButtonCloseMenu��$y�	Collapsed=�$��60��$��60��$��5q�$
��Left=�$	��Top=�#��[ ���	#FF31577E��Z� ��Z� .��  $ 	ArrowLeft=�$��25��$��25���� -    ��Name$ 	menuLabel��$��Меню��$��Center=����	#FF31577E$��70, 5, 5, 0q�$��20(��� $��80��$��Bottom=��� -    ��Name$ ListViewMenu�����	#FF5C99D6$��Disabled=�.@��� -	    ��Name$ 
ItemPeople��$��60��.���� $ 
Horizontal=�.+�  $ People=�$��25��$��25��$��10q��� $��Люди��$��Center=�$��20 10q��� -
   $ ItemContacts��$��60��.���� $ 
Horizontal=�.+�  $ Virus=�$��25��$��25��$��10q��� $��Контакты��$��Center=�$��20 10q�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ SelectionChanged��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *SelectedPageCommand+    CommandParameter  �� ! �� ElementName$! ListViewMenu��