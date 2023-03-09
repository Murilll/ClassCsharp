Cachorro dog1 = new Cachorro("Doguinho", "PitBull", "Fulano", true, "latido", 50, "Pelo_baixo", false);
Cachorro dog2 = new Cachorro("Dogão", "Pincher", "Siclano", false, "latidoMuitoForte", 500, "Pelo_baixo", true);
Cachorro dog3 = new Cachorro("Dog", "ViraLata", "Cara", true, "lateDeVezEmQuando", 10, "Pelo_baixo", true);

Gato cat1 = new Gato("Perrito", "Fofo", 9, "Gato", true, "Latido?", 50, "Peludinho", false);
Gato cat2 = new Gato("Gato", "DeBotas", 1, "Perrito", false, "Miado", 50, "PeludinhoFofo", false);
Gato cat3 = new Gato("CatPataMansa", "GatoDeBotas", 9, "Gato", true, "Miado", 80, "Peludinha", false);

Dragao drag1 = new Dragao("Banguela", "FuriaDaNoite", 1, "Soluço", true, "Barulhento", 500, "escamas", true, "Terra", 4, false, "RajadaDeLuz");
Dragao drag2 = new Dragao("Zeus", "Relamp", 5, "N/", false, "RugidoMuitoAlto", 3000, "liso", true, "Ar", 4, true, "RajadaDeRelampago");

Carro car1 = new Carro("TOYOTA", "Corolla", 5, 320);
Carro car2 = new Carro("HONDA", "Civic", 5, 400);
Carro car3 = new Carro("HONDA", "Fit", 4, 380);
Moto moto1 = new Moto("YAMAHA", "XJ6", 600, 350);
Caminhao cami1 = new Caminhao("Mercedes-Benz", "435-54", 50000, 180);

Console.WriteLine($"ANTES: {car1.Velocidade}");
car1.Acelerar(60);
Console.WriteLine($"DEPOIS: {car1.Velocidade}");


Carro.ShowAllCar();

//Console.WriteLine(drag1.Habitat);
//drag1.Mudança("AGUA");
//Console.WriteLine(drag1.Habitat);

