   M S B A M L   `   `   `  ����G  CMusicCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MusicCatalogMusicCatalog  5   	   M+clr-namespace:MusicCatalog.Views.ConvertersMusicCatalog.Views.Converters  5	   	       MusicCatalog.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Acontrols,http://metro.mahapps.com/winfx/xaml/controls     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   &localclr-namespace:MusicCatalog  5   	   <
converters+clr-namespace:MusicCatalog.Views.Converters  5	   	   -   5          � Title$  
MainWindow��5   	   $	��334��6   $	��318��6)    � 
ResizeMode$ NoResize=�65    � SizeToContent$ WidthAndHeight=�6K    � 	Resources 5      8   2MusicCatalog.Views.Converters.StringToIntConverter   StringToIntConverter  GroupedItems �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%�   &	        &	        5   
   6*   �� 5   
    64   �� *SearchResults+ 5        5      $ CatalogObjectType��6+   5      5      .��5      � .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��
Поиск��6n   $
��Bold"�6{   �� 5   
     PlaceholderTextBoxStyle#��[ 6.   
 � Tag$* $Артист, трек, альбом��6_   $
��Left=�6z   $��	10,31,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��88��6�   4  .System.Windows.Automation.AutomationProperties	   HelpText$;	 5Имя артиста, название трека...��6�   
 �� MaxLines$
 1��6  ��6   �� *
SearchText+6  �� 5   
   -   5         ��Name$ searchListBox��5      $��10,54,180,10q�6�   $	��128��6�   $	��254��6�   ��6)   ��  �� Source# [  �� SelectedItem 6f   �� *SelectedCatalogObject+ �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5         HeaderTemplate 5      �� 5      .R�5      �� $
��Bold"�6(   $��16(�6:   ��6H   �� *Name+5       5"      ��5&      �� 5'      .R�5(      �� ��6    �� *Designation+5)      5+      �� 5,   
   $
��Left=�6   $��
144,13,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $
��Bold"�6o   �� 6�    � Language$ ru-ru�6�   $�Фильтры��6�   6�   �� 5-   
   $
��Left=�6   $��
198,32,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ ru-ru�6t   $�
Общие��6�   6�   �� 5.   
   $��Center=�6   $��0,58,0,0q�61   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ ru-ru�6t   $�Жанр��6�   6�   �� 5/   
    �� DisplayMemberPath$
 Name��62   $
��Left=�6r   $��188,55,10,0q�6�   $	��Top=�6�   $	��120��6�    �� 
IsEditable$
 True��6�    �� StaysOpenOnEdit$
 True��6�   ��6   �� *Genres+ 6K   �� *SelectedGenre+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 50      +  %Microsoft.Xaml.Behaviors.EventTrigger  51         	EventName$ DropDownOpened��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 52      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *UpdateGenresListCommand+53      55      �� 56   
   $
��Left=�6   $��
246,84,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ ru-ru�6t   $�-��6�   6�   �� 57   
   $
��Left=�6   $��
144,84,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ ru-ru�6t   $�Год��6�   6�   �� 58   
   #��[ 6^   $ C��6�   $
��Left=�6�   $��
188,84,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��50��6�   $
 1��6�   ��6   �� *	StartYear+ �� 	Converter# [  6�   �� 59   
   #��[ 6\   $
 По��6�   $
��Left=�6�   $��258,84,10,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��50��6�   $
 1��6�   ��6   �� *	EndYear+# [  6�   �� 5:   
   $
��Left=�6   $��201,114,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ ru-ru�6u   $�
Треки��6�   6�   �� 5;   
   $
��Left=�6   $��144,135,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ ru-ru�6u   $(�"Длительность (сек.)��6�   6�   �� 5<   
   $
��Left=�6   $��201,156,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $ ru-ru�6u   $�-��6�   6�   �� 5=   
   #��[ 6`   $
 От��6�   $
��Left=�6�   $��143,156,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��50��6�   $
 1��6  ��6   �� *MinDuration+# [  6  �� 5>   
   #��[ 6`   $
 До��6�   $
��Left=�6�   $��213,156,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��50��6�   $
 1��6  ��6   �� *MaxDuration+# [  6  �� 5?   
   $
��Left=�6   $��144,192,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $
��Bold"�6p   �� 6�   $ ru-ru�6�   $�Создание��6�   6�   �� 5@   
   -   5         ��Name$ ArtistCreationButton��5@      $#��Создать артиста��6/   $
��Left=�6I   $��143,213,0,0q�6d   $	��Top=�6y   $	��108��6�   6�   �� 5A   
   -   5        $ GenreCreationButton��5A      $��Создать жанр��6.   $
��Left=�6E   $��143,238,0,0q�6`   $	��Top=�6u   $	��108��6�   6�   �� 5B   
   -   5        $ AlbumCreationButton��5B      $!��Создать альбом��6.   $
��Left=�6G   $��143,263,0,35q�6b   $	��108��6x   6�   �� 5C   
   -   5        $ PlaylistCreationButton��5C      $%��Создать плейлист��61   $
��Left=�6L   $��143,288,0,0q�6g   $	��Top=�6|   $	��108��6�   6�   �� 5D   
   $��
Поиск��63   $
��Left=�6C   $��	98,31,0,0q�6^   $	��Top=�6q   $��40��6�   $��18��6�   ��6   �� *SearchCommand+6�   5F      5G      