function ht(e,t={target:document.body},n="hmr",o="app-loaded"){const r=document.getElementById(n),s=document.createElement("div");s.style.visibility="hidden",t.target.appendChild(s),r?addEventListener(o,i):i();function i(){removeEventListener(o,i),r&&r.remove(),s.style.visibility=null,s.setAttribute("id",n)}return new e({...t,target:s})}function x(){}function Ue(e,t){for(const n in t)e[n]=t[n];return e}function qe(e){return e()}function $e(){return Object.create(null)}function q(e){e.forEach(qe)}function ge(e){return typeof e=="function"}function B(e,t){return e!=e?t==t:e!==t||e&&typeof e=="object"||typeof e=="function"}let oe;function xe(e,t){return oe||(oe=document.createElement("a")),oe.href=t,e===oe.href}function mt(e){return Object.keys(e).length===0}function ye(e,...t){if(e==null)return x;const n=e.subscribe(...t);return n.unsubscribe?()=>n.unsubscribe():n}function Q(e){let t;return ye(e,n=>t=n)(),t}function U(e,t,n){e.$$.on_destroy.push(ye(t,n))}function _t(e,t,n,o){if(e){const r=Be(e,t,n,o);return e[0](r)}}function Be(e,t,n,o){return e[1]&&o?Ue(n.ctx.slice(),e[1](o(t))):n.ctx}function gt(e,t,n,o){if(e[2]&&o){const r=e[2](o(n));if(t.dirty===void 0)return r;if(typeof r=="object"){const s=[],i=Math.max(t.dirty.length,r.length);for(let c=0;c<i;c+=1)s[c]=t.dirty[c]|r[c];return s}return t.dirty|r}return t.dirty}function yt(e,t,n,o,r,s){if(r){const i=Be(t,n,o,s);e.p(i,r)}}function bt(e){if(e.ctx.length>32){const t=[],n=e.ctx.length/32;for(let o=0;o<n;o++)t[o]=-1;return t}return-1}function Fn(e){return e==null?"":e}function wt(e,t,n){return e.set(n),t}const Pt=(e,t)=>Object.prototype.hasOwnProperty.call(e,t);function kt(e){return e&&ge(e.destroy)?e.destroy:x}function Dn(e,t){e.appendChild(t)}function L(e,t,n){e.insertBefore(t,n||null)}function E(e){e.parentNode.removeChild(e)}function Un(e,t){for(let n=0;n<e.length;n+=1)e[n]&&e[n].d(t)}function be(e){return document.createElement(e)}function qn(e,t){const n={};for(const o in e)Pt(e,o)&&t.indexOf(o)===-1&&(n[o]=e[o]);return n}function He(e){return document.createTextNode(e)}function we(){return He(" ")}function G(){return He("")}function W(e,t,n){n==null?e.removeAttribute(t):e.getAttribute(t)!==n&&e.setAttribute(t,n)}function $t(e){return Array.from(e.childNodes)}function Bn(e,t){t=""+t,e.wholeText!==t&&(e.data=t)}function Ke(e,t,n,o){n===null?e.style.removeProperty(t):e.style.setProperty(t,n,o?"important":"")}let X;function J(e){X=e}function Pe(){if(!X)throw new Error("Function called outside component initialization");return X}function xt(e){Pe().$$.on_destroy.push(e)}function Ve(e,t){return Pe().$$.context.set(e,t),t}function We(e){return Pe().$$.context.get(e)}const z=[],Ee=[],se=[],ve=[],ze=Promise.resolve();let de=!1;function Je(){de||(de=!0,ze.then(Qe))}function Et(){return Je(),ze}function pe(e){se.push(e)}const fe=new Set;let re=0;function Qe(){const e=X;do{for(;re<z.length;){const t=z[re];re++,J(t),vt(t.$$)}for(J(null),z.length=0,re=0;Ee.length;)Ee.pop()();for(let t=0;t<se.length;t+=1){const n=se[t];fe.has(n)||(fe.add(n),n())}se.length=0}while(z.length);for(;ve.length;)ve.pop()();de=!1,fe.clear(),J(e)}function vt(e){if(e.fragment!==null){e.update(),q(e.before_update);const t=e.dirty;e.dirty=[-1],e.fragment&&e.fragment.p(e.ctx,t),e.after_update.forEach(pe)}}const ie=new Set;let N;function H(){N={r:0,c:[],p:N}}function K(){N.r||q(N.c),N=N.p}function _(e,t){e&&e.i&&(ie.delete(e),e.i(t))}function b(e,t,n,o){if(e&&e.o){if(ie.has(e))return;ie.add(e),N.c.push(()=>{ie.delete(e),o&&(n&&e.d(1),o())}),e.o(t)}else o&&o()}function Rt(e,t){e.d(1),t.delete(e.key)}function Lt(e,t){b(e,1,1,()=>{t.delete(e.key)})}function Ge(e,t,n,o,r,s,i,c,a,l,u,p){let m=e.length,h=s.length,f=m;const w={};for(;f--;)w[e[f].key]=f;const k=[],R=new Map,S=new Map;for(f=h;f--;){const g=p(r,s,f),$=n(g);let d=i.get($);d?o&&d.p(g,t):(d=l($,g),d.c()),R.set($,k[f]=d),$ in w&&S.set($,Math.abs(f-w[$]))}const M=new Set,ne=new Set;function F(g){_(g,1),g.m(c,u),i.set(g.key,g),u=g.first,h--}for(;m&&h;){const g=k[h-1],$=e[m-1],d=g.key,P=$.key;g===$?(u=g.first,m--,h--):R.has(P)?!i.has(d)||M.has(d)?F(g):ne.has(P)?m--:S.get(d)>S.get(P)?(ne.add(d),F(g)):(M.add(P),m--):(a($,i),m--)}for(;m--;){const g=e[m];R.has(g.key)||a(g,i)}for(;h;)F(k[h-1]);return k}function Ot(e,t){const n={},o={},r={$$scope:1};let s=e.length;for(;s--;){const i=e[s],c=t[s];if(c){for(const a in i)a in c||(o[a]=1);for(const a in c)r[a]||(n[a]=c[a],r[a]=1);e[s]=c}else for(const a in i)r[a]=1}for(const i in o)i in n||(n[i]=void 0);return n}function It(e){return typeof e=="object"&&e!==null?e:{}}function A(e){e&&e.c()}function T(e,t,n,o){const{fragment:r,on_mount:s,on_destroy:i,after_update:c}=e.$$;r&&r.m(t,n),o||pe(()=>{const a=s.map(qe).filter(ge);i?i.push(...a):q(a),e.$$.on_mount=[]}),c.forEach(pe)}function C(e,t){const n=e.$$;n.fragment!==null&&(q(n.on_destroy),n.fragment&&n.fragment.d(t),n.on_destroy=n.fragment=null,n.ctx=[])}function Tt(e,t){e.$$.dirty[0]===-1&&(z.push(e),Je(),e.$$.dirty.fill(0)),e.$$.dirty[t/31|0]|=1<<t%31}function Y(e,t,n,o,r,s,i,c=[-1]){const a=X;J(e);const l=e.$$={fragment:null,ctx:null,props:s,update:x,not_equal:r,bound:$e(),on_mount:[],on_destroy:[],on_disconnect:[],before_update:[],after_update:[],context:new Map(t.context||(a?a.$$.context:[])),callbacks:$e(),dirty:c,skip_bound:!1,root:t.target||a.$$.root};i&&i(l.root);let u=!1;if(l.ctx=n?n(e,t.props||{},(p,m,...h)=>{const f=h.length?h[0]:m;return l.ctx&&r(l.ctx[p],l.ctx[p]=f)&&(!l.skip_bound&&l.bound[p]&&l.bound[p](f),u&&Tt(e,p)),m}):[],l.update(),u=!0,q(l.before_update),l.fragment=o?o(l.ctx):!1,t.target){if(t.hydrate){const p=$t(t.target);l.fragment&&l.fragment.l(p),p.forEach(E)}else l.fragment&&l.fragment.c();t.intro&&_(e.$$.fragment),T(e,t.target,t.anchor,t.customElement),Qe()}J(a)}class Z{$destroy(){C(this,1),this.$destroy=x}$on(t,n){const o=this.$$.callbacks[t]||(this.$$.callbacks[t]=[]);return o.push(n),()=>{const r=o.indexOf(n);r!==-1&&o.splice(r,1)}}$set(t){this.$$set&&!mt(t)&&(this.$$.skip_bound=!0,this.$$set(t),this.$$.skip_bound=!1)}}var I={queryHandler:{parse:e=>Ct(new URLSearchParams(e)),stringify:e=>"?"+new URLSearchParams(e).toString()},urlTransform:{apply:e=>e,remove:e=>e},useHash:!1};function Ct(e){return[...e].reduce((t,[n,o])=>(t[n]=o,t),{})}const Xe=RegExp(/\:([^/()]+)/g);function St(e,t){if(navigator.userAgent.includes("jsdom"))return!1;t&&Ye(e),At()}function At(){if(navigator.userAgent.includes("jsdom"))return!1;const{hash:e}=window.location;if(e){const t=document.getElementById(e.substring(1));t&&t.scrollIntoView()}}function Ye(e){e&&e.scrollTo&&e.dataset.routify!=="scroll-lock"&&e.dataset["routify-scroll"]!=="lock"&&(e.style["scroll-behavior"]="auto",e.scrollTo({top:0,behavior:"auto"}),e.style["scroll-behavior"]="",Ye(e.parentElement))}const jt=(e,t)=>{const n=t?"":"/?$";return e=e.replace(/\/_fallback?$/,"(/|$)"),e=e.replace(/\/index$/,"(/index)?"),e=e.replace(Xe,"([^/]+)")+n,e=`^${e}`,e},Ze=e=>{const t=[];let n;for(;n=Xe.exec(e);)t.push(n[1]);return t},Nt=({path:e})=>e.split("/").filter(Boolean).map(t=>t==="_fallback"?"A":t.startsWith(":")?"B":"C").join("");function ce(e,t){ce._console=ce._console||{log:console.log,warn:console.warn};const{_console:n}=ce,o=e.componentFile.name.replace(/Proxy<_?(.+)>/,"$1").replace(/^Index$/,e.component.shortPath.split("/").pop()).replace(/^./,s=>s.toUpperCase()).replace(/\:(.+)/,"U5B$1u5D"),r=[`<${o}> received an unexpected slot "default".`,`<${o}> was created with unknown prop 'scoped'`,`<${o}> was created with unknown prop 'scopedSync'`];for(const s of["log","warn"])console[s]=(...i)=>{r.includes(i[0])||n[s](...i)},t().then(()=>{console[s]=n[s]})}function le(){let e=window.location.pathname+window.location.search+window.location.hash;const{url:t,options:n}=Mt(e);return{...he(t),options:n}}function Mt(e){const[t,n]=e.split("__[[routify_url_options]]__"),o=JSON.parse(decodeURIComponent(n||"")||"{}");return window.routify=window.routify||{},window.routify.prefetched=o.prefetch,{url:t,options:o}}function he(e){I.useHash&&(e=e.replace(/.*#(.+)/,"$1"));const t=e.startsWith("/")?window.location.origin:void 0,n=new URL(e,t),o=n.pathname+n.search+n.hash;return{url:n,fullpath:o}}function ue(e,t,n){const o=I.useHash?"#":"";let r;return r=Ft(e,t,n),r=I.urlTransform.apply(r),r=o+r,r}function Ft(e,t,n){const o=Object.assign({},n,t),r=Dt(e,t);for(const[s,i]of Object.entries(o))e=e.replace(`:${s}`,i);return`${e}${r}`}function Dt(e,t){if(!I.queryHandler)return"";const n=Ze(e),o={};return t&&Object.entries(t).forEach(([r,s])=>{n.includes(r)||(o[r]=s)}),I.queryHandler.stringify(o).replace(/\?$/,"")}function Ut(e){let t;const n=e[2].default,o=_t(n,e,e[1],null);return{c(){o&&o.c()},m(r,s){o&&o.m(r,s),t=!0},p(r,[s]){o&&o.p&&(!t||s&2)&&yt(o,n,r,r[1],t?gt(n,r[1],s,null):bt(r[1]),null)},i(r){t||(_(o,r),t=!0)},o(r){b(o,r),t=!1},d(r){o&&o.d(r)}}}function qt(e,t,n){let{$$slots:o={},$$scope:r}=t,{scoped:s={}}=t;return e.$$set=i=>{"scoped"in i&&n(0,s=i.scoped),"$$scope"in i&&n(1,r=i.$$scope)},[s,r,o]}class Bt extends Z{constructor(t){super(),Y(this,t,qt,Ut,B,{scoped:0})}}const D=[];function Ht(e,t){return{subscribe:j(e,t).subscribe}}function j(e,t=x){let n;const o=new Set;function r(c){if(B(e,c)&&(e=c,n)){const a=!D.length;for(const l of o)l[1](),D.push(l,e);if(a){for(let l=0;l<D.length;l+=2)D[l][0](D[l+1]);D.length=0}}}function s(c){r(c(e))}function i(c,a=x){const l=[c,a];return o.add(l),o.size===1&&(n=t(r)||x),c(e),()=>{o.delete(l),o.size===0&&(n(),n=null)}}return{set:r,update:s,subscribe:i}}function ee(e,t,n){const o=!Array.isArray(e),r=o?[e]:e,s=t.length<2;return Ht(n,i=>{let c=!1;const a=[];let l=0,u=x;const p=()=>{if(l)return;u();const h=t(o?a[0]:a,i);s?i(h):u=ge(h)?h:x},m=r.map((h,f)=>ye(h,w=>{a[f]=w,l&=~(1<<f),c&&p()},()=>{l|=1<<f}));return c=!0,p(),function(){q(m),u()}})}window.routify=window.routify||{};const V=j(null),te=j([]);te.subscribe(e=>window.routify.routes=e);let et=j({component:{params:{}}});const Kt=j(null),tt=j(!0);async function Vt({page:e,metatags:t,afterPageLoad:n,parentNode:o}){const r=e.last!==e;setTimeout(()=>St(o,r));const{path:s}=e,{options:i}=le(),c=i.prefetch;for(const a of n._hooks)a&&await a(e.api);t.update(),dispatchEvent(new CustomEvent("app-loaded")),parent.postMessage({msg:"app-loaded",prefetched:window.routify.prefetched,path:s,prefetchId:c},"*"),window.routify.appLoaded=!0,window.routify.stopAutoReady=!1}function me(e,t=!1){e=I.urlTransform.remove(e);let{pathname:n,search:o}=he(e).url;const r=Q(te),s=r.find(u=>n===u.meta.name)||r.find(u=>n.match(u.regex));if(!s)throw new Error(`Route could not be found for "${n}".`);const i=t?Object.create(s):s,{route:c,redirectPath:a,rewritePath:l}=nt(i,r);return l&&({pathname:n,search:o}=he(ue(l,c.params)).url,a&&(c.redirectTo=ue(a,c.params||{}))),I.queryHandler&&(c.params=Object.assign({},I.queryHandler.parse(o))),Wt(c,n),c.leftover=e.replace(new RegExp(c.regex),""),c}function Wt(e,t){if(e.paramKeys){const n=zt(e.layouts),o=t.split("/").filter(Boolean);Jt(e.path).forEach((s,i)=>{s&&(e.params[s]=o[i],n[i]?n[i].param={[s]:o[i]}:e.param={[s]:o[i]})})}}function nt(e,t,n,o){const{redirect:r,rewrite:s}=e.meta;if(r||s){n=r?r.path||r:n,o=s?s.path||s:n;const i=r&&r.params,c=s&&s.params,a=t.find(l=>l.path.replace(/\/index$/,"")===o);return a===e&&console.error(`${o} is redirecting to itself`),a||console.error(`${e.path} is redirecting to non-existent path: ${o}`),(i||c)&&(a.params=Object.assign({},a.params,i,c)),nt(a,t,n,o)}return{route:e,redirectPath:n,rewritePath:o}}function zt(e){const t=[];return e.forEach(n=>{t[n.path.split("/").filter(Boolean).length-1]=n}),t}function Jt(e){return e.split("/").filter(Boolean).map(t=>t.match(/\:(.+)/)).map(t=>t&&t[1])}function Re(e,t,n){const o=e.slice();return o[1]=t[n],o}function Le(e,t){let n,o;return{key:e,first:null,c(){n=be("iframe"),xe(n.src,o=t[1].url)||W(n,"src",o),W(n,"frameborder","0"),W(n,"title","routify prefetcher"),this.first=n},m(r,s){L(r,n,s)},p(r,s){t=r,s&1&&!xe(n.src,o=t[1].url)&&W(n,"src",o)},d(r){r&&E(n)}}}function Qt(e){let t,n=[],o=new Map,r=e[0];const s=i=>i[1].options.prefetch;for(let i=0;i<r.length;i+=1){let c=Re(e,r,i),a=s(c);o.set(a,n[i]=Le(a,c))}return{c(){t=be("div");for(let i=0;i<n.length;i+=1)n[i].c();W(t,"id","__routify_iframes"),Ke(t,"display","none")},m(i,c){L(i,t,c);for(let a=0;a<n.length;a+=1)n[a].m(t,null)},p(i,[c]){c&1&&(r=i[0],n=Ge(n,c,s,1,i,r,o,t,Rt,Le,null,Re))},i:x,o:x,d(i){i&&E(t);for(let c=0;c<n.length;c+=1)n[c].d()}}}const Gt=2,_e=j([]),ot=ee(_e,e=>e.slice(0,Gt));ot.subscribe(e=>e.forEach(({options:t})=>{setTimeout(()=>rt(t.prefetch),t.timeout)}));function rt(e){const t=e.data?e.data.prefetchId:e;if(!t)return null;const n=Q(_e).find(o=>o&&o.options.prefetch==t);if(n){const{gracePeriod:o}=n.options,r=new Promise(i=>setTimeout(i,o)),s=new Promise(i=>{window.requestIdleCallback?window.requestIdleCallback(i):setTimeout(i,o+1e3)});Promise.all([r,s]).then(()=>{_e.update(i=>i.filter(c=>c.options.prefetch!=t))})}}addEventListener("message",rt,!1);function Xt(e,t,n){let o;return U(e,ot,r=>n(0,o=r)),[o]}class Yt extends Z{constructor(t){super(),Y(this,t,Xt,Qt,B,{})}}function ke(){return We("routify")||et}const Zt={subscribe(e){const t=[];return ee(te,n=>{n.forEach(r=>{const s=r.layouts.map(i=>i.api).filter(i=>!t.includes(i));t.push(r.api,...s)});const o=t.find;return t.find=(r,...s)=>typeof r=="string"?t.find(i=>i.meta.name===r)||t.find(i=>i.path===r):o.bind(t)(r,...s),t}).subscribe(e)}},Hn=Zt,Kn={subscribe(e){const t=ke();return ee(t,n=>n.layout.api).subscribe(e)}},en={_hooks:[e=>tt.set(!1)],subscribe:st},tn={_hooks:[],subscribe:st};function st(e){const t=this._hooks,n=t.length;return e(o=>{t[n]=o}),(...o)=>{delete t[n],e(...o)}}const nn={subscribe(e){const t=ke();return ee(t,n=>on(n,n.route,n.routes)).subscribe(e)}};function on(e,t,n){return function(r,s={},i){const{component:c}=e,a=Object.assign({},t.params,c.params);let l=r&&r.nodeType&&r;l&&(r=r.getAttribute("href")),r=r?h(r):c.shortPath;const u=n.find(f=>[f.shortPath||"/",f.path].includes(r));if(u&&u.meta.preload==="proximity"&&window.requestIdleCallback){const f=routify.appLoaded?0:1500;setTimeout(()=>{window.requestIdleCallback(()=>u.api.preload())},f)}i&&i.strict!==!1||(r=r.replace(/index$/,""));let m=ue(r,s,a);if(l)return l.href=m,{update(f){l.href=ue(r,f,a)}};return m;function h(f){if(f.match(/^\.\.?\//)){let[,w,k]=f.match(/^([\.\/]+)(.*)/),R=c.path.replace(/\/$/,"");const S=w.match(/\.\.\//g)||[];c.isPage&&S.push(null),S.forEach(()=>R=R.replace(/\/[^\/]+\/?$/,"")),f=`${R}/${k}`.replace(/\/$/,""),f=f||"/"}else if(!f.match(/^\//)){const w=n.find(k=>k.meta.name===f);w&&(f=w.shortPath)}return f}}}const Vn={subscribe(e){return ee([nn,V],([t,n])=>function(r="",s={},{strict:i}={strict:!0}){r=t(r,s,{strict:i});const c=t(n.path,s,{strict:i}),a=new RegExp("^"+r+"($|/)");return!!c.match(a)}).subscribe(e)}},y={subscribe(e){return this._origin=this.getOrigin(),e(ae)},props:{},templates:{},services:{plain:{propField:"name",valueField:"content"},twitter:{propField:"name",valueField:"content"},og:{propField:"property",valueField:"content"}},plugins:[{name:"applyTemplate",condition:()=>!0,action:(e,t)=>{const n=y.getLongest(y.templates,e)||(o=>o);return[e,n(t)]}},{name:"createMeta",condition:()=>!0,action(e,t){y.writeMeta(e,t)}},{name:"createOG",condition:e=>!e.match(":"),action(e,t){y.writeMeta(`og:${e}`,t)}},{name:"createTitle",condition:e=>e==="title",action(e,t){document.title=t}}],getLongest(e,t){const n=e[t];if(n){const o=Q(V).path,i=Object.keys(e[t]).filter(c=>o.includes(c)).sort((c,a)=>a.length-c.length)[0];return n[i]}},writeMeta(e,t){const n=document.getElementsByTagName("head")[0],o=e.match(/(.+)\:/),r=o&&o[1]||"plain",{propField:s,valueField:i}=ae.services[r]||ae.services.plain,c=document.querySelector(`meta[${s}='${e}']`);c&&c.remove();const a=document.createElement("meta");a.setAttribute(s,e),a.setAttribute(i,t),a.setAttribute("data-origin","routify"),n.appendChild(a)},set(e,t){typeof e=="string"&&y.plugins.forEach(n=>{n.condition(e,t)&&([e,t]=n.action(e,t)||[e,t])})},clear(){const e=document.querySelector("meta");e&&e.remove()},template(e,t){const n=y.getOrigin;y.templates[e]=y.templates[e]||{},y.templates[e][n]=t},update(){Object.keys(y.props).forEach(e=>{let t=y.getLongest(y.props,e);y.plugins.forEach(n=>{n.condition(e,t)&&([e,t]=n.action(e,t)||[e,t])})})},batchedUpdate(){y._pendingUpdate||(y._pendingUpdate=!0,setTimeout(()=>{y._pendingUpdate=!1,this.update()}))},_updateQueued:!1,_origin:!1,getOrigin(){if(this._origin)return this._origin;const e=ke();return e&&Q(e).path||"/"},_pendingUpdate:!1},ae=new Proxy(y,{set(e,t,n,o){const{props:r}=e;return Reflect.has(e,t)?Reflect.set(e,t,n,o):(r[t]=r[t]||{},r[t][e.getOrigin()]=n),window.routify.appLoaded&&e.batchedUpdate(),!0}});function Oe(e,t,n){const o=e.slice();return o[21]=t[n].component,o[22]=t[n].componentFile,o[2]=t[n].decorator,o[1]=t[n].nodes,o}function Ie(e){let t=[],n=new Map,o,r,s=[e[4]];const i=c=>c[7];for(let c=0;c<1;c+=1){let a=Oe(e,s,c),l=i(a);n.set(l,t[c]=Ce(l,a))}return{c(){for(let c=0;c<1;c+=1)t[c].c();o=G()},m(c,a){for(let l=0;l<1;l+=1)t[l].m(c,a);L(c,o,a),r=!0},p(c,a){a&33554621&&(s=[c[4]],H(),t=Ge(t,a,i,1,c,s,n,o.parentNode,Lt,Ce,o,Oe),K())},i(c){if(!r){for(let a=0;a<1;a+=1)_(t[a]);r=!0}},o(c){for(let a=0;a<1;a+=1)b(t[a]);r=!1},d(c){for(let a=0;a<1;a+=1)t[a].d(c);c&&E(o)}}}function Te(e){let t,n;return t=new it({props:{decorator:e[2],nodes:e[1],scoped:{...e[0],...e[25]}}}),{c(){A(t.$$.fragment)},m(o,r){T(t,o,r),n=!0},p(o,r){const s={};r&4&&(s.decorator=o[2]),r&16&&(s.nodes=o[1]),r&33554433&&(s.scoped={...o[0],...o[25]}),t.$set(s)},i(o){n||(_(t.$$.fragment,o),n=!0)},o(o){b(t.$$.fragment,o),n=!1},d(o){C(t,o)}}}function rn(e){let t,n,o=e[21]&&e[1].length&&Te(e);return{c(){o&&o.c(),t=G()},m(r,s){o&&o.m(r,s),L(r,t,s),n=!0},p(r,s){r[21]&&r[1].length?o?(o.p(r,s),s&16&&_(o,1)):(o=Te(r),o.c(),_(o,1),o.m(t.parentNode,t)):o&&(H(),b(o,1,1,()=>{o=null}),K())},i(r){n||(_(o),n=!0)},o(r){b(o),n=!1},d(r){o&&o.d(r),r&&E(t)}}}function sn(e){let t,n,o;const r=[{scoped:e[0]},{scopedSync:e[5]},e[3].param||{}];var s=e[22];function i(c){let a={$$slots:{default:[rn,({scoped:l,decorator:u})=>({25:l,2:u}),({scoped:l,decorator:u})=>(l?33554432:0)|(u?4:0)]},$$scope:{ctx:c}};for(let l=0;l<r.length;l+=1)a=Ue(a,r[l]);return{props:a}}return s&&(t=new s(i(e))),{c(){t&&A(t.$$.fragment),n=we()},m(c,a){t&&T(t,c,a),L(c,n,a),o=!0},p(c,a){const l=a&41?Ot(r,[a&1&&{scoped:c[0]},a&32&&{scopedSync:c[5]},a&8&&It(c[3].param||{})]):{};if(a&100663317&&(l.$$scope={dirty:a,ctx:c}),s!==(s=c[22])){if(t){H();const u=t;b(u.$$.fragment,1,0,()=>{C(u,1)}),K()}s?(t=new s(i(c)),A(t.$$.fragment),_(t.$$.fragment,1),T(t,n.parentNode,n)):t=null}else s&&t.$set(l)},i(c){o||(t&&_(t.$$.fragment,c),o=!0)},o(c){t&&b(t.$$.fragment,c),o=!1},d(c){t&&C(t,c),c&&E(n)}}}function Ce(e,t){let n,o,r,s;var i=t[2];function c(a){return{props:{scoped:a[0],$$slots:{default:[sn]},$$scope:{ctx:a}}}}return i&&(o=new i(c(t))),{key:e,first:null,c(){n=G(),o&&A(o.$$.fragment),r=G(),this.first=n},m(a,l){L(a,n,l),o&&T(o,a,l),L(a,r,l),s=!0},p(a,l){t=a;const u={};if(l&1&&(u.scoped=t[0]),l&67108925&&(u.$$scope={dirty:l,ctx:t}),i!==(i=t[2])){if(o){H();const p=o;b(p.$$.fragment,1,0,()=>{C(p,1)}),K()}i?(o=new i(c(t)),A(o.$$.fragment),_(o.$$.fragment,1),T(o,r.parentNode,r)):o=null}else i&&o.$set(u)},i(a){s||(o&&_(o.$$.fragment,a),s=!0)},o(a){o&&b(o.$$.fragment,a),s=!1},d(a){a&&E(n),a&&E(r),o&&C(o,a)}}}function Se(e){let t,n,o,r;return{c(){t=be("div"),Ke(t,"display","contents")},m(s,i){L(s,t,i),o||(r=kt(n=e[10].call(null,t)),o=!0)},d(s){s&&E(t),o=!1,r()}}}function cn(e){let t,n,o,r=e[4]&&Ie(e),s=!e[6]&&Se(e);return{c(){r&&r.c(),t=we(),s&&s.c(),n=G()},m(i,c){r&&r.m(i,c),L(i,t,c),s&&s.m(i,c),L(i,n,c),o=!0},p(i,[c]){i[4]?r?(r.p(i,c),c&16&&_(r,1)):(r=Ie(i),r.c(),_(r,1),r.m(t.parentNode,t)):r&&(H(),b(r,1,1,()=>{r=null}),K()),i[6]?s&&(s.d(1),s=null):s||(s=Se(i),s.c(),s.m(n.parentNode,n))},i(i){o||(_(r),o=!0)},o(i){b(r),o=!1},d(i){r&&r.d(i),i&&E(t),s&&s.d(i),i&&E(n)}}}function an(e,t,n){let o,r,s,i,c;U(e,V,d=>n(14,s=d)),U(e,te,d=>n(16,c=d));let{nodes:a=[]}=t,{scoped:l={}}=t,{decorator:u=void 0}=t,p=null,m=null,h={},f,w=1;const k=j(null);U(e,k,d=>n(4,r=d));const R=We("routify")||et;U(e,R,d=>n(15,i=d));const S=d=>n(6,f=d.parentNode);Ve("routify",k);let M=[];function ne(d){let P=d.component();P instanceof Promise?P.then(F):F(P)}function F(d){n(5,h={...l});const P={...r,nodes:m,decorator:u||Bt,layout:p.isLayout?p:i.layout,component:p,route:s,routes:c,componentFile:d,parentNode:f||i.parentNode};k.set(P),wt(R,i.child=p,i),m.length===0&&g()}async function g(){await new Promise(P=>setTimeout(P));const d=r.component.path===s.path;!window.routify.stopAutoReady&&d&&Vt({page:r.component,metatags:ae,afterPageLoad:en,parentNode:f})}function $({meta:d,path:P,param:dt,params:pt}){return JSON.stringify({path:P,invalidate:w,param:(d["param-is-page"]||d["slug-is-page"])&&dt,queryParams:d["query-params-is-page"]&&pt})}return e.$$set=d=>{"nodes"in d&&n(1,a=d.nodes),"scoped"in d&&n(0,l=d.scoped),"decorator"in d&&n(2,u=d.decorator)},e.$$.update=()=>{e.$$.dirty&6146&&M!==a&&(n(12,M=a),n(3,[p,...m]=[...a],p),n(3,p.api.reset=()=>n(11,w++,w),p)),e.$$.dirty&8&&ne(p),e.$$.dirty&2064&&n(7,o=r&&w&&$(r.component)),e.$$.dirty&16&&r&&ce(r,Et)},[l,a,u,p,r,h,f,o,k,R,S,w,M]}class it extends Z{constructor(t){super(),Y(this,t,an,cn,B,{nodes:1,scoped:0,decorator:2})}}function ln(e,t){let n=!1;function o(s,i){const c=s||le().fullpath,a=me(c);a.redirectTo&&(history.replaceStateNative({},null,a.redirectTo),delete a.redirectTo);const p=[...(i&&me(le().fullpath,e)||a).layouts,a];n&&delete n.last,a.last=n,n=a,s||Kt.set(a),V.set(a),a.api.preload().then(()=>{tt.set(!0),t(p)})}const r=un(o);return{updatePage:o,destroy:r}}function un(e){["pushState","replaceState"].forEach(r=>{history[r+"Native"]||(history[r+"Native"]=history[r]),history[r]=async function(s={},i,c){const a=location.pathname+location.search+location.hash;if(c===a)return!1;const{id:l,path:u,params:p}=Q(V);s={id:l,path:u,params:p,...s};const m=new Event(r.toLowerCase());if(Object.assign(m,{state:s,title:i,url:c}),await Ae(m,c))return history[r+"Native"].apply(this,[s,i,c]),dispatchEvent(m)}});let t=!1;const n={click:fn,pushstate:()=>e(),replacestate:()=>e(),popstate:async r=>{t?t=!1:await Ae(r,le().fullpath)?e():(t=!0,r.preventDefault(),history.go(1))}};return Object.entries(n).forEach(r=>addEventListener(...r)),()=>{Object.entries(n).forEach(r=>removeEventListener(...r))}}function fn(e){const t=e.target.closest("a")||e.composedPath().find(s=>s.tagName==="A"),n=t&&t.href;if(e.ctrlKey||e.metaKey||e.altKey||e.shiftKey||e.button||e.defaultPrevented||!n||t.target||t.host!==location.host)return;const o=new URL(n),r=o.pathname+o.search+o.hash;e.preventDefault(),history.pushState({},"",r)}async function Ae(e,t){const n=me(t).api;for(const o of tn._hooks.filter(Boolean))if(!await o(e,n,{url:t}))return!1;return!0}function je(e){let t,n;return t=new it({props:{nodes:e[0]}}),{c(){A(t.$$.fragment)},m(o,r){T(t,o,r),n=!0},p(o,r){const s={};r&1&&(s.nodes=o[0]),t.$set(s)},i(o){n||(_(t.$$.fragment,o),n=!0)},o(o){b(t.$$.fragment,o),n=!1},d(o){C(t,o)}}}function dn(e){let t,n,o,r=e[0]&&e[1]!==null&&je(e);return n=new Yt({}),{c(){r&&r.c(),t=we(),A(n.$$.fragment)},m(s,i){r&&r.m(s,i),L(s,t,i),T(n,s,i),o=!0},p(s,[i]){s[0]&&s[1]!==null?r?(r.p(s,i),i&3&&_(r,1)):(r=je(s),r.c(),_(r,1),r.m(t.parentNode,t)):r&&(H(),b(r,1,1,()=>{r=null}),K())},i(s){o||(_(r),_(n.$$.fragment,s),o=!0)},o(s){b(r),b(n.$$.fragment,s),o=!1},d(s){r&&r.d(s),s&&E(t),C(n,s)}}}function pn(e,t,n){let o;U(e,V,h=>n(1,o=h));let{routes:r}=t,{config:s={}}=t,i,c;window.routify=window.routify||{},window.routify.inBrowser=!window.navigator.userAgent.match("jsdom"),Object.assign(I,s),Ve("routifyupdatepage",(...h)=>c&&c.updatePage(...h));const l=h=>n(0,i=h),u=()=>{!c||(c.destroy(),c=null)};let p=null;const m=()=>{clearTimeout(p),p=setTimeout(()=>{u(),c=ln(r,l),te.set(r),c.updatePage()})};return xt(u),e.$$set=h=>{"routes"in h&&n(2,r=h.routes),"config"in h&&n(3,s=h.config)},e.$$.update=()=>{e.$$.dirty&4&&r&&m()},[i,o,r,s]}class hn extends Z{constructor(t){super(),Y(this,t,pn,dn,B,{routes:2,config:3})}}function v(e){const t=async function(o){return await ct(e,{file:o.tree,state:{treePayload:o},scope:{}})};return t.sync=function(o){return at(e,{file:o.tree,state:{treePayload:o},scope:{}})},t}async function ct(e,t){const n=await e(t);if(n===!1)return!1;const o=n||t.file;if(o.children){const r=await Promise.all(o.children.map(async s=>ct(e,{state:t.state,scope:lt(t.scope||{}),parent:t.file,file:await s})));o.children=r.filter(Boolean)}return o}function at(e,t){const n=e(t);if(n===!1)return!1;const o=n||t.file;if(o.children){const r=o.children.map(s=>at(e,{state:t.state,scope:lt(t.scope||{}),parent:t.file,file:s}));o.children=r.filter(Boolean)}return o}function lt(e){return JSON.parse(JSON.stringify(e))}const mn=v(({file:e})=>{(e.isPage||e.isFallback)&&(e.regex=jt(e.path,e.isFallback))}),_n=v(({file:e})=>{e.paramKeys=Ze(e.path)}),gn=v(({file:e})=>{e.isFallback||e.isIndex?e.shortPath=e.path.replace(/\/[^/]+$/,""):e.shortPath=e.path}),yn=v(({file:e})=>{e.ranking=Nt(e)}),bn=v(({file:e})=>{const t=e,n=e.meta&&e.meta.children||[];n.length&&(t.children=t.children||[],t.children.push(...n.map(o=>({isMeta:!0,...o,meta:o}))))}),wn=v(e=>{const{file:t}=e,{isFallback:n,meta:o}=t,r=t.path.split("/").pop().startsWith(":"),s=t.path.endsWith("/index"),i=o.index||o.index===0,c=o.index===!1;t.isIndexable=i||!n&&!r&&!s&&!c,t.isNonIndexable=!t.isIndexable}),Pn=v(({file:e,parent:t})=>{Object.defineProperty(e,"parent",{get:()=>t}),Object.defineProperty(e,"nextSibling",{get:()=>Ne(e,1)}),Object.defineProperty(e,"prevSibling",{get:()=>Ne(e,-1)}),Object.defineProperty(e,"lineage",{get:()=>ut(t)})});function ut(e,t=[]){return e&&(t.unshift(e),ut(e.parent,t)),t}function Ne(e,t){if(!e.root){const n=e.parent.children.filter(r=>r.isIndexable),o=n.indexOf(e);return n[o+t]}}const kn=v(({file:e,parent:t})=>{e.isIndex&&Object.defineProperty(t,"index",{get:()=>e})}),$n=v(({file:e,scope:t})=>{Object.defineProperty(e,"layouts",{get:()=>n(e)});function n(o){if(!o.isLayout&&o.meta.reset)return[];const{parent:r}=o,s=r&&r.component&&r,i=s&&(s.isReset||s.meta.reset),c=r&&!i&&n(r)||[];return s&&c.push(s),c}}),xn=e=>{v(t=>{(t.file.isPage||t.file.isFallback)&&t.state.treePayload.routes.push(t.file)}).sync(e),e.routes.sort((t,n)=>t.ranking>=n.ranking?-1:1)},En=v(({file:e})=>{const t=e.root?a:e.children?e.isPage?i:o:e.isReset?c:e.isLayout?n:e.isFallback?r:s;Object.setPrototypeOf(e,t.prototype);function n(){}function o(){}function r(){}function s(){}function i(){}function c(){}function a(){}});var vn=Object.freeze(Object.defineProperty({__proto__:null,setRegex:mn,setParamKeys:_n,setShortPath:gn,setRank:yn,addMetaChildren:bn,setIsIndexable:wn,assignRelations:Pn,assignIndex:kn,assignLayout:$n,createFlatList:xn,setPrototype:En},Symbol.toStringTag,{value:"Module"}));const Rn={isDir:!1,ext:"svelte",isLayout:!1,isReset:!1,isIndex:!1,isFallback:!1,isPage:!1,ownMeta:{},meta:{recursive:!0,preload:!1,prerender:!0},id:"__fallback"};function ft(e){return Object.entries(Rn).forEach(([t,n])=>{typeof e[t]=="undefined"&&(e[t]=n)}),e.children&&(e.children=e.children.map(ft)),e}const Ln=v(({file:e})=>{e.api=new On(e)});class On{constructor(t){this.__file=t,Object.defineProperty(this,"__file",{enumerable:!1}),this.isMeta=!!t.isMeta,this.path=t.path,this.title=In(t),this.meta=t.meta}get parent(){return!this.__file.root&&this.__file.parent.api}get children(){return(this.__file.children||this.__file.isLayout&&this.__file.parent.children||[]).filter(t=>!t.isNonIndexable).sort((t,n)=>t.isMeta&&n.isMeta?0:(t=(t.meta.index||t.meta.title||t.path).toString(),n=(n.meta.index||n.meta.title||n.path).toString(),t.localeCompare(n,void 0,{numeric:!0,sensitivity:"base"}))).map(({api:t})=>t)}get next(){return Me(this,1)}get prev(){return Me(this,-1)}async preload(){const t=[...this.__file.layouts,this.__file,this.index&&this.index.__file].filter(Boolean).map(n=>n.component());await Promise.all(t)}get component(){return this.__file.component?this.__file.component():this.__file.index?this.__file.index.component():!1}get componentWithIndex(){return new Promise(t=>Promise.all([this.component,this.index&&this.index.component]).then(n=>t(n)))}get index(){const t=this.__file.children&&this.__file.children.find(n=>n.isIndex);return t&&t.api}}function Me(e,t){if(!e.__file.root){const o=e.parent.children.indexOf(e);return e.parent.children[o+t]}}function In(e){return typeof e.meta.title!="undefined"?e.meta.title:(e.shortPath||e.path).split("/").pop().replace(/-/g," ")}const Fe={...vn,restoreDefaults:({tree:e})=>ft(e),assignAPI:Ln};function Tn(e){const t=["restoreDefaults","setParamKeys","setRegex","setShortPath","setRank","assignLayout","setPrototype","addMetaChildren","assignRelations","setIsIndexable","assignIndex","assignAPI","createFlatList"],n={tree:e,routes:[]};for(let o of t)(Fe[o].sync||Fe[o])(n);return n}const Cn=function(){const t=document.createElement("link").relList;return t&&t.supports&&t.supports("modulepreload")?"modulepreload":"preload"}(),De={},Sn="/",O=function(t,n){return!n||n.length===0?t():Promise.all(n.map(o=>{if(o=`${Sn}${o}`,o in De)return;De[o]=!0;const r=o.endsWith(".css"),s=r?'[rel="stylesheet"]':"";if(document.querySelector(`link[href="${o}"]${s}`))return;const i=document.createElement("link");if(i.rel=r?"stylesheet":Cn,r||(i.as="script",i.crossOrigin=""),i.href=o,document.head.appendChild(i),r)return new Promise((c,a)=>{i.addEventListener("load",c),i.addEventListener("error",()=>a(new Error(`Unable to preload CSS for ${o}`)))})})).then(()=>t())},An={root:!0,children:[{isFallback:!0,path:"/_fallback",component:()=>O(()=>import("./_fallback.763f3559.js"),[]).then(e=>e.default)},{isIndex:!0,isPage:!0,path:"/index",id:"_index",component:()=>O(()=>import("./index.7a816ac5.js"),[]).then(e=>e.default)},{isDir:!0,children:[{isIndex:!0,isPage:!0,path:"/guide/index",id:"_guide_index",component:()=>O(()=>import("./index.797e75ac.js"),[]).then(e=>e.default)},{ext:"md",isPage:!0,path:"/guide/markdown",id:"_guide_markdown",component:()=>O(()=>import("./markdown.71ec8daa.js"),[]).then(e=>e.default)},{isPage:!0,path:"/guide/milligram",id:"_guide_milligram",component:()=>O(()=>import("./milligram.69790591.js"),[]).then(e=>e.default)},{ext:"md",isPage:!0,path:"/guide/routify",id:"_guide_routify",component:()=>O(()=>import("./routify.5b35cf00.js"),[]).then(e=>e.default)},{ext:"md",isPage:!0,path:"/guide/vite",id:"_guide_vite",component:()=>O(()=>import("./vite.a6ed86b0.js"),[]).then(e=>e.default)}],isLayout:!0,ownMeta:{index:50},meta:{index:50,recursive:!0,preload:!1,prerender:!0},path:"/guide",id:"_guide__layout",component:()=>O(()=>import("./_layout.a55d207c.js"),[]).then(e=>e.default)}],isLayout:!0,path:"/",id:"__layout",component:()=>O(()=>import("./_layout.d7be0c01.js"),[]).then(e=>e.default)},{tree:Wn,routes:jn}=Tn(An);function Nn(e){let t,n;return t=new hn({props:{routes:jn}}),{c(){A(t.$$.fragment)},m(o,r){T(t,o,r),n=!0},p:x,i(o){n||(_(t.$$.fragment,o),n=!0)},o(o){b(t.$$.fragment,o),n=!1},d(o){C(t,o)}}}class Mn extends Z{constructor(t){super(),Y(this,t,null,Nn,B,{})}}ht(Mn,{target:document.body},"routify-app");export{H as A,K as B,Kn as C,qn as D,Z as S,L as a,we as b,W as c,E as d,be as e,Fn as f,Dn as g,_t as h,Y as i,bt as j,gt as k,_ as l,b as m,x as n,Un as o,U as p,Hn as q,Vn as r,B as s,He as t,yt as u,nn as v,Bn as w,A as x,T as y,C as z};