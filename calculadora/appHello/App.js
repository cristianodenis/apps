import React,{Component} from 'react';
import {View,Text,Button,TextInput,StyleSheet} from 'react-native';

class App extends Component{

  constructor(props){
    super(props);
    this.state = {
      soma:'denis'
    };
    this.calcular = this.calcular.bind(this);
  }
  calcular(){
    soma: 'felipe'
  }
  render(){
    return(
      <View>
        <Text style={{textAlign:'center',color:'blue',fontSize:30}}>calculadora</Text>

        <View>
        <TextInput style={{marginTop:30,height:45,borderWidth:1}}
        placeholder='digite um número:'
        onChangeText={this.state.soma1}/>
        </View>

        <View>
        <TextInput style={{marginTop:30,height:45,borderWidth:1}}
         placeholder='digite outro número:'
         onChangeText={this.state.soma2}/>
        </View>

        <Text style={{textAlign:'center',fontSize:30,marginTop:40}}>{this.state.soma}</Text>

        <View style={{marginTop:60}}>
        <Button  title= 'calcular' onPress={this.calcular} />
        </View>
        
      </View>
      
      
    );
  } 
  
}
export default App;