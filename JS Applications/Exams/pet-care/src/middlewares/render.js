import { render, html } from '../../node_modules/lit-html/lit-html.js';
import * as userService from '../api/user.js';

const navTemplate = (user) => html`
<nav>
    <section class="logo">
        <img src="./images/logo.png" alt="logo">
    </section>
    <ul>
        <!--Users and Guest-->
        <li><a href="/">Home</a></li>
        <li><a href="/dashboard">Dashboard</a></li>
        ${!user
          ? html`<li><a href="/login">Login</a></li>
                 <li><a href="/register">Register</a></li>`
          : html`<li><a href="/create">Create Postcard</a></li>
                 <li><a href="/logout">Logout</a></li>` 
        } 
    </ul>
</nav>`;

const header = document.querySelector('.navigation-header');
const root = document.getElementById('content');

function renderCtx(content) {
    render(content, root);
}

export function addRender(ctx, next) {
    render(navTemplate(ctx.user), header);
    ctx.render = renderCtx;
    next();
}

export function onLogout(ctx){
    userService.logout();
    ctx.page.redirect('/');
}