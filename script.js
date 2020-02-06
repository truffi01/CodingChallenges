//convert underscore and dashes into camel case

function toCamelCase(str){
  let result = str.split("_|-")
  return result; 
  }


  toCamelCase("the-stealth-warrior")
  toCamelCase("The_Stealth_Warrior")