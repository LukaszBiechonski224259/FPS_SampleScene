# FPS_SampleScene
przykładowa scena z gry FPS  stworzona na potrzeby zadania rekrutacyjnego.

Sterowanie:

poruszanie się: WSAD lub strzałki
Strzał: LPM (Mouse0)
Zmiana broni: kółko myszki(MouseWheeel Down / MouseWheel Up)

Obiekty niszczalne dziedziczą z klasy Interactable parametr durability i materiał wykonania.
Klasa Interactable posiada zaimplementowaną funkcję OnDestroy, pozwalającą na wywołanie dowolnego kodu przed zniszczeniem obiektu.
W zależności od potrzeb może być też nadpisana przez dowolną klasę dziedziczącą. 

Zaimplementowane są trzy rodzaje materiałów wykonania: Steel, Fabric, Wood. 
Dostępne są trzy bronie: Karabin, Shotgun, Pistolet. 

Karabin może niszczyć obiekty ze stali. Damage został ustawiony na 5.
Shotgun może niszczyć obiekty drewniane. Damage został ustawiony na 10.
Pistolet może niszczyć obiekty materiałowe. Damage został ustawiony na 2.
Wartości obrażeń oraz rodzaj materiału można dowolnie zmienić w edytorze.

Każdy karabin ma unikalny dzwięk strzału. Niestety particle zostały rozgrzebane i nie zostały ukończone. 

Na Środku ekranu pokazuje się czerwona kropka, która służy za asystent celowania. 

(Z uwagi na niedokonczone particle i brak innego dowodu na trafienie obiektu zostawiłem Debug Logi aktywne.)
