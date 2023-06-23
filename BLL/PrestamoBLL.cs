using Microsoft.EntityFrameworkCore;
using RecupeParcial1.DAL;
using RecupeParcial1.Models;


namespace RecupeParcial1.BLL
{
    public class PrestamoBLL
    {

        //Recibiendo el contexto
        private readonly Contexto _context;
        public PrestamoBLL(Contexto context)
        {
            _context = context;
        }

        //Método Existe
        public bool Existe(int PrestamoId)
        {
            return _context.prestamo.Any(i => i.PrestamoId == PrestamoId);
        }

        //Método Insertar
        public bool Insertar(Prestamo prestamo)
        {
            _context.prestamo.Add(prestamo);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        //Método Guardar
        public bool Guardar(Prestamo prestamo)
        {
            if (!Existe(prestamo.PrestamoId))
                return Insertar(prestamo);
            else
                return Modificar(prestamo);
        }

        //Método Modificar
        public bool Modificar(Prestamo prestamo)
        {
            _context.prestamo.Entry(prestamo).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        //Método Eliminar
        public bool Eliminar(Prestamo prestamo)
        {
            _context.prestamo.Remove(prestamo);
            int eliminado = _context.SaveChanges();
            return eliminado > 0;
        }

    }
}
