namespace Istravel.Models{
    public static class Sitios{
        public static int[] CantSitios = new int[4];

        public static int[] calcularCantSitios (int decision){
            CantSitios[decision-1]++;
            return CantSitios;
        }

        public static int[] GenerarSitios(){
            return CantSitios;
        }
    }
}