var guidArray = {};

function createGUID() {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000)
            .toString(16)
            .substring(1);
    }
    return s4() + s4() + '-' + s4() + '-' + s4() + '-' + s4() + '-' + s4() + s4() + s4();
}
const assemblyName = 'BlazorClassicForms';

function CallEvent(uid, ev) {
    var methodName = 'InvokeEvent';

    //const methodTypeInfo = Blazor.platform.findMethod(
    //    assemblyName,
    //    namespace,
    //    typeName,
    //    methodName
    //);

    var eventuid = createGUID();
    guidArray[eventuid] = ev;

    DotNet.invokeMethodAsync(assemblyName, methodName, [uid, eventuid]);

//    Blazor.platform.callMethod(methodTypeInfo, null, [Blazor.platform.toDotNetString(uid), Blazor.platform.toDotNetString(eventuid)]);

    delete guidArray[eventuid];
}

function CallMouseEvent(uid, ev) {
    var methodName = 'InvokeMouseEvent';

    //const methodTypeInfo2 = Blazor.platform.findMethod(
    //    assemblyName,
    //    namespace,
    //    typeName,
    //    methodName
    //);
    var uuiToDelete = null;
    if (ev.currentTarget.gui == null) {
        var uui = createGUID();
        guidArray[uui] = ev.currentTarget;
        ev.currentTarget.gui = uui;

        uuiToDelete = uui;
    }

    var eventuid = createGUID();
    guidArray[eventuid] = ev;

    var data = ev.x + '\n' + ev.y + '\n' + ev.clientX + '\n' + ev.clientY + '\n' + ev.layerX + '\n' + ev.layerY + '\n' + ev.currentTarget.gui + '\n' + ev.button + '\n' + eventuid;

    try {

        DotNet.invokeMethodAsync(assemblyName, methodName, [uid, data]);
    } catch (e) {
        console.log(e);
    }

    delete guidArray[eventuid];
    if (uuiToDelete != null) {
        delete guidArray[uuiToDelete];
    }
}

var documentGUI = createGUID();
guidArray[documentGUI] = document;
document.gui = bodyGUI;

var bodyGUI = createGUID();
guidArray[bodyGUI] = document.body;
document.body.gui = bodyGUI;

var windowGUI = createGUID();
guidArray[windowGUI] = window;
window.gui = windowGUI;

var windowNavgatorGUI = createGUID();
guidArray[windowNavgatorGUI] = window.navigator;

function createElement(tagName) {
    var uui = createGUID();
    guidArray[uui] = document.createElement(tagName);
    guidArray[uui].gui = uui;
    return uui;
}

function createDocumentFragment() {
    var uui = createGUID();
    guidArray[uui] = document.createDocumentFragment();
    guidArray[uui].gui = uui;
    return uui;
}

function _document() {
    return documentGUI;
}
function _body() {
    return bodyGUI;
}
function _window() {
    return windowGUI;
}
function _navigator() {
    return windowNavgatorGUI;
}

function onmousedown(instance, value) {
    return guidArray[instance].onmousedown = (ev) => {
        CallMouseEvent(value, ev);
    };
}
function onchange(instance, value) {
    return guidArray[instance].onchange = (ev) => {
        CallEvent(value, ev);
    };
}
function onresize(instance, value) {
    return guidArray[instance].onresize = (ev) => {
        CallEvent(value, ev);
    };
}
function onpaste(instance, value) {
    return guidArray[instance].onpaste = (ev) => {
        CallEvent(value, ev);
    };
}
function onmouseenter(instance, value) {
    return guidArray[instance].onmouseenter = (ev) => {
        CallMouseEvent(value, ev);
    };
}
function onmouseleave(instance, value) {
    return guidArray[instance].onmouseleave = (ev) => {
        CallMouseEvent(value, ev);
    };
}
function onkeydown(instance, value) {
    return guidArray[instance].onkeydown = (ev) => {
        CallEvent(value, ev);
    };
}
function onkeyup(instance, value) {
    return guidArray[instance].onkeyup = (ev) => {
        CallEvent(value, ev);
    };
}
function onblur(instance, value) {
    return guidArray[instance].onblur = (ev) => {
        CallEvent(value, ev);
    };
}
function onclick(instance, value) {
    return guidArray[instance].onclick = (ev) => {
        CallEvent(value, ev);
    };
}
function ondblclick(instance, value) {
    return guidArray[instance].ondblclick = (ev) => {
        CallMouseEvent(value, ev);
    };
}
function onmousemove(instance, value) {
    guidArray[instance].addEventListener('mousemove', (ev) => {
        CallMouseEvent(value, ev);
    });
}
function onmouseup(instance, value) {
    guidArray[instance].addEventListener('mouseup', (ev) => {
        CallMouseEvent(value, ev);
    });
}
function stopPropagation(instance) {
    guidArray[instance].stopPropagation();
}
function getAttribute(instance, name) {
    return guidArray[instance].getAttribute(name);
}

function document_activeElement_get() {
    if (document.activeElement == null) {
        return '';
    } else {
        if (document.activeElement.gui == null) {
            var uui = createGUID();
            guidArray[uui] = document.activeElement;
            document.activeElement.gui = uui;
            return uui;
        } else {
            return document.activeElement.gui;
        }
    }
}

function element_childnode(instance, index) {
    var ini = guidArray[instance].childNodes[index];
    if (ini.gui == null) {
        var uui = createGUID();
        guidArray[uui] = ini;
        ini.gui = uui;
        return uui;
    } else {
        return ini.gui;
    }
}

function element_parentElement_get(instance) {
    var ini = guidArray[instance].parentElement;
    if (ini == null)
        return "";

    if (ini.gui == null) {
        var uui = createGUID();
        guidArray[uui] = ini;
        ini.gui = uui;
        return uui;
    } else {
        return ini.gui;
    }
}

function element_parentElement_set(instance, other) {
    guidArray[instance].parentElement = guidArray[other];
}

function document_activeElement_set(uui) {
    if (uui == "")
        document.activeElement = null;
    else {
        document.activeElement = guidArray[uui];
    }
}

function setAttribute(instance, name, value) {
    guidArray[instance].setAttribute(name, value);
}

function removeAttribute(instance, name, value) {
    guidArray[instance].removeAttribute(name);
}

function appendChild(instance, child) {
    guidArray[instance].appendChild(guidArray[child]);
}
function removeChild(instance, child) {
    guidArray[instance].removeChild(guidArray[child]);
}
function insertBefore(instance, child, child2) {
    guidArray[instance].insertBefore(guidArray[child], guidArray[child2]);
}
function classList_contains(instance, value) {
    return guidArray[instance].classList.contains(value);
}

function classList_remove(instance, value) {
    return guidArray[instance].classList.remove(value);
}

function classList_add(instance, value) {
    return guidArray[instance].classList.add(value);
}

function innerHTML_get(instance) {
    return guidArray[instance].innerHTML;
}

function element_get(instance, method) {
    return guidArray[instance][method];
}

function element_set(instance, method, value) {
    guidArray[instance][method] = value;
}

function element_style_get(instance, method) {
    return (guidArray[instance].style)[method];
}

function element_style_set(instance, method, value) {
    (guidArray[instance].style)[method] = value;
}

function element_call(instance, method) {
    guidArray[instance][method]();
}

function element_call_ret(instance, method) {
    return guidArray[instance][method]();
}

function getBoundingClientRect(instance) {
    var rect = guidArray[instance].getBoundingClientRect();

    return rect.left + ',' + rect.top + ',' + rect.right + ',' + rect.bottom + ',' +
        rect.x + ',' + rect.y + ',' + rect.width + ',' + rect.height;
}

function getOffsetPoint(instance, IsFF) {
    var top = 0;
    var left = 0;
    var element = guidArray[instance];

    do {
        var dym = element;
        if (IsFF) {
            var rec = element.getBoundingClientRect();
            top += rec.top;
            left += rec.left;

            element = element.parentElement;
        }
        else {
            top += dym.offsetTop;
            left += dym.offsetLeft;
            element = dym.offsetParent;
        }


    } while (element != null);

    return left + ',' + top;
}

function innerHTML_set(instance, innerHTML) {
    guidArray[instance].innerHTML = innerHTML;
}