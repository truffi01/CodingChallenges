// return masked string
function maskify(cc) {
  
    if (cc.length <= 4){
      return cc
    }
    
    for (let i = cc.length-1 ; i >= 0; i--){
      if (i[cc] > i[cc.length-5]){
        i[cc] = '#'  
      }
    }
    
    return cc;
  }

