# RacingOfAnimalsAndRobots
Animals are the jackal and  ostrich. Robots are snailBot and mechanicElephant.

Variables names are Turkish because this program's class diagram is Turkish.

Class diagram...
------------------------------------------------------------------------------------------------------------------------
hayvanlar ve robotların katılım sağlayabileceği bir yarışı simüle edeceğiz. Tüm yarışmacılar, yarışma oluşturulurken
tanımlanacak toplam N + 1 konumluk bir pistin 0. konumundan yarışa başlayacaktır. Her konum, yarış boyunca yarışmacıların
bulunabileceği yerleri ifade eder. N. konuma ilk varan ya da geçen, yarışmayı kazanacaktır.
Yarış kaygan ve ağır bir zeminde olduğu için, yarışmacılar zaman zaman kayabilmekte veya daha ağır hareket etmektedir. Her
turda, her bir yarışmacı bir kez hareket edecektir. Aşağıdaki tabloda yarışmacıların hangi hareketi yüzde kaç olasılıkla
gerçekleştirdiği verilmiştir. Herhangi bir yarışmacının başlangıç karesinden daha geriye kaymasına veya gitmesine müsaade
edilmeyecektir.
----------------------------------------------------------------
Yarışmacı |  Hareket Tipi | Yüzde |  Gerçekleştirilecek Hareket
----------------------------------------------------------------
            Koşma          %30      3 ileri    
Çakal       Yürüme         %50      2 ileri
            Kayma          %20      4 geri
----------------------------------------------------------------
            Koşma          %50      3 ileri
DeveKuşu    Hızlı Koşma    %20      6 ileri
            Kayma          %30      4 geri
----------------------------------------------------------------
            Yürüme         %40      2 ileri
MekanikFil  Koşma          %10      3 ileri
            Bekleme        %50      -
----------------------------------------------------------------
SalyanBot   Sürünme        %100     1 ileri
----------------------------------------------------------------
Ayrıca yarışmacılar arasında, türlerinden kaynaklanan davranış ilişkileri olacaktır.
1) Çakal, bir Devekuşunu arkadan başlayarak bir Devekuşuyla aynı pozisyona gelirse, %50 olasılıkla Devekuşunu avlayarak
paralize edecektir. Paralize olan bir Devekuşu, yarışın geri kalanında hiç hareket etmeyecektir.
2) Mekanik Fil, bir Devekuşunu arkadan başlayarak bir Devekuşuyla aynı pozisyona gelirse, Devekuşunun ayağına %20
olasılıkla basarak Devekuşunu sakatlayarak paralize edecektir. Paralize olan bir Devekuşu, yarışın geri kalanında hiç
hareket etmeyecektir.
3) SalyanBotlar sürünme hareketi sonunda ulaştıkları yeni konumda bulunan hayvanları %25 ihtimalle çarparlar. Çarpılan bir
hayvan anlık olarak şoka girer ve geriye doğru devrilir. Bu durumda, hayvan bir konum geri gider. Çarpılma bunun dışında
bir etki yaratmaz; hayvan yarış boyunca hareket etmeye devam edebilir.
Herhangi bir yarışmacı bitiş çizgisini geçtiği anda yarışma sona ermiş olacaktır ve tüm yarışmacılar o anda bulundukları pozisyona
göre sıralanarak, konumlarıyla beraber ekrana çıktı olarak verilecektir. Her konum için, o konumda bulunan yarışmacıların
numaraları ve isimleri yazdırılacaktır.

![resim_2022-06-05_165214680](https://user-images.githubusercontent.com/87274613/172053976-94a55d68-3ae9-492f-bd5b-286e9d7abcf1.png)
