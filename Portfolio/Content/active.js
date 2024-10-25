function _class(name){
    return document.getElementsByClassName(name);
  }
  
  let tabPanes = _class("tab-header")[0].getElementsByTagName("div");
  
  for(let i = 0;i<tabPanes.length;i++){
    tabPanes[i].addEventListener("click",function(){
      _class("tab-header")[0].getElementsByClassName("actives")
      [0].classList.remove("actives");
      tabPanes[i].classList.add("actives");
  
      _class("tab-indicator")[0].style.top = `calc(75px + ${i*92.2}px)` ;
  
      _class("tab-content")[0].getElementsByClassName("actives")
      [0].classList.remove("actives");
  
      _class("tab-content")[0].getElementsByTagName("div")
      [i].classList.add("actives");
    })
  }