   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:MusicCatalog.Views.CreationWindows"MusicCatalog.Views.CreationWindows  5   	   =    7MusicCatalog.Views.CreationWindows.ArtistCreationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:MusicCatalog.Views.CreationWindows     5   	     � Title$%  Создание артиста��5   	   $	��124��6"   $	��140��6/    � 
ResizeMode$ NoResize=�6;    � SizeToContent$ WidthAndHeight=�6Q   .��5	      � .+�5
   
   ��    PlaceholderTextBoxStyle#��[  6W   
 � Tag$ Имя��6�   $
��Left=�6�   $��10,10,10,10q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�    �� MaxLines$ 1��6�   ��6   �� *NameFieldValue+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   #��[  6Z   $ Страна��6�   $
��Left=�6�   $��10,33,10,10q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $ 1��6   ��6   �� *CountryFieldValue+$ PropertyChanged=�6   �� 5   
   $��Активен��67   $
��Left=�6I   $��10,56,10,10q�6d   $	��Top=�6y    J� RenderTransformOrigin$ 0.266,0.312&�6�    d� 	IsChecked 6   �� *IsActiveValue+6�   �� 5   
   -   5        $��Создать��5   b   $
��Left=�6t   $��70,78,10,10q�6�   $	��Top=�6�   $��60��6�   ��6   �� *CreateCommand+{�63   �� *CreateCommand.CanExecute+6�   5      5      