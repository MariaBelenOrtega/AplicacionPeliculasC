using System;
using System.ComponentModel;
using System.Diagnostics;

namespace AplicacionPeliculas.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscaCompania m_BuscaCompania;

            public BuscaCompania BuscaCompania
            {
                [DebuggerHidden]
                get
                {
                    m_BuscaCompania = Create__Instance__(m_BuscaCompania);
                    return m_BuscaCompania;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscaCompania))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscaCompania);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscaGenero m_BuscaGenero;

            public BuscaGenero BuscaGenero
            {
                [DebuggerHidden]
                get
                {
                    m_BuscaGenero = Create__Instance__(m_BuscaGenero);
                    return m_BuscaGenero;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscaGenero))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscaGenero);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscaIdioma m_BuscaIdioma;

            public BuscaIdioma BuscaIdioma
            {
                [DebuggerHidden]
                get
                {
                    m_BuscaIdioma = Create__Instance__(m_BuscaIdioma);
                    return m_BuscaIdioma;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscaIdioma))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscaIdioma);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public BuscaUsuario m_BuscaUsuario;

            public BuscaUsuario BuscaUsuario
            {
                [DebuggerHidden]
                get
                {
                    m_BuscaUsuario = Create__Instance__(m_BuscaUsuario);
                    return m_BuscaUsuario;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BuscaUsuario))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BuscaUsuario);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public BusquedaPais m_BusquedaPais;

            public BusquedaPais BusquedaPais
            {
                [DebuggerHidden]
                get
                {
                    m_BusquedaPais = Create__Instance__(m_BusquedaPais);
                    return m_BusquedaPais;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BusquedaPais))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BusquedaPais);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Compañia m_Compañia;

            public Compañia Compañia
            {
                [DebuggerHidden]
                get
                {
                    m_Compañia = Create__Instance__(m_Compañia);
                    return m_Compañia;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Compañia))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Compañia);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Cuenta m_Cuenta;

            public Cuenta Cuenta
            {
                [DebuggerHidden]
                get
                {
                    m_Cuenta = Create__Instance__(m_Cuenta);
                    return m_Cuenta;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Cuenta))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Cuenta);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Espera m_Espera;

            public Espera Espera
            {
                [DebuggerHidden]
                get
                {
                    m_Espera = Create__Instance__(m_Espera);
                    return m_Espera;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Espera))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Espera);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Genero m_Genero;

            public Genero Genero
            {
                [DebuggerHidden]
                get
                {
                    m_Genero = Create__Instance__(m_Genero);
                    return m_Genero;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Genero))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Genero);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Idioma m_Idioma;

            public Idioma Idioma
            {
                [DebuggerHidden]
                get
                {
                    m_Idioma = Create__Instance__(m_Idioma);
                    return m_Idioma;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Idioma))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Idioma);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public inicio m_inicio;

            public inicio inicio
            {
                [DebuggerHidden]
                get
                {
                    m_inicio = Create__Instance__(m_inicio);
                    return m_inicio;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_inicio))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_inicio);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificaGenero m_ModificaGenero;

            public ModificaGenero ModificaGenero
            {
                [DebuggerHidden]
                get
                {
                    m_ModificaGenero = Create__Instance__(m_ModificaGenero);
                    return m_ModificaGenero;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificaGenero))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificaGenero);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificaIdioma m_ModificaIdioma;

            public ModificaIdioma ModificaIdioma
            {
                [DebuggerHidden]
                get
                {
                    m_ModificaIdioma = Create__Instance__(m_ModificaIdioma);
                    return m_ModificaIdioma;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificaIdioma))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificaIdioma);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarCompañia m_ModificarCompañia;

            public ModificarCompañia ModificarCompañia
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarCompañia = Create__Instance__(m_ModificarCompañia);
                    return m_ModificarCompañia;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarCompañia))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarCompañia);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModificarPais m_ModificarPais;

            public ModificarPais ModificarPais
            {
                [DebuggerHidden]
                get
                {
                    m_ModificarPais = Create__Instance__(m_ModificarPais);
                    return m_ModificarPais;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModificarPais))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModificarPais);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Pais m_Pais;

            public Pais Pais
            {
                [DebuggerHidden]
                get
                {
                    m_Pais = Create__Instance__(m_Pais);
                    return m_Pais;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Pais))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Pais);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Pelicula m_Pelicula;

            public Pelicula Pelicula
            {
                [DebuggerHidden]
                get
                {
                    m_Pelicula = Create__Instance__(m_Pelicula);
                    return m_Pelicula;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Pelicula))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Pelicula);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Peliculas m_Peliculas;

            public Peliculas Peliculas
            {
                [DebuggerHidden]
                get
                {
                    m_Peliculas = Create__Instance__(m_Peliculas);
                    return m_Peliculas;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Peliculas))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Peliculas);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TablasIntermedias m_TablasIntermedias;

            public TablasIntermedias TablasIntermedias
            {
                [DebuggerHidden]
                get
                {
                    m_TablasIntermedias = Create__Instance__(m_TablasIntermedias);
                    return m_TablasIntermedias;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TablasIntermedias))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TablasIntermedias);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Usuario m_Usuario;

            public Usuario Usuario
            {
                [DebuggerHidden]
                get
                {
                    m_Usuario = Create__Instance__(m_Usuario);
                    return m_Usuario;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Usuario))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Usuario);
                }
            }

        }


    }
}