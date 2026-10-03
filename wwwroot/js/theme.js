// Rhino Performance — cambio de tema claro/oscuro y menú móvil.
// El tema inicial se aplica en el <head> del layout (evita el "parpadeo");
// este archivo solo maneja los clics.
(function () {
    const KEY = 'rhino-theme';
    const root = document.documentElement;

    function setTheme(theme) {
        root.setAttribute('data-theme', theme);
        try { localStorage.setItem(KEY, theme); } catch (e) { /* almacenamiento no disponible */ }
        document.querySelectorAll('.theme-toggle').forEach(btn => {
            btn.setAttribute('aria-checked', theme === 'dark' ? 'true' : 'false');
            btn.setAttribute('aria-label', theme === 'dark' ? 'Modo oscuro activado' : 'Modo claro activado');
        });
    }

    document.addEventListener('DOMContentLoaded', () => {
        setTheme(root.getAttribute('data-theme') || 'dark');

        document.querySelectorAll('.theme-toggle').forEach(btn =>
            btn.addEventListener('click', () =>
                setTheme(root.getAttribute('data-theme') === 'dark' ? 'light' : 'dark')));

        const toggle = document.querySelector('.menu-toggle');
        const nav = document.querySelector('.main-nav');
        if (toggle && nav) {
            toggle.addEventListener('click', () => {
                const open = nav.classList.toggle('open');
                toggle.setAttribute('aria-expanded', open);
            });
            nav.querySelectorAll('a').forEach(a =>
                a.addEventListener('click', () => nav.classList.remove('open')));
        }
    });
})();