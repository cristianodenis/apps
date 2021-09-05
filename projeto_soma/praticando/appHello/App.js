import React, {Component} from 'react';
import {View,Text,Button,StyleSheet} from 'react-native';

class App extends Component{

  constructor(props){
    super(props);
    this.state={
     soma: 0

    };
    
    this.subtrair = this.subtrair.bind(this); //bind para poder acessar as props
    this.adicionar = this.adicionar.bind(this);

  }

  adicionar(){
    this.setState({
      soma: this.state.soma +1 
    })
  }
 
  subtrair(){
    this.setState({
     soma: this.state.soma  -1
    })

  }
  
  render(){
    
    return(
      <View>
        <Text style={styles.testo}>contagem</Text>
         
        <Text style={styles.soma}> 
          {this.state.soma}</Text>
        
        <View style={styles.botao}>
         <Button title='+' onPress={this.adicionar}/>  
          <Button title='--' onPress={this.subtrair}/>  
        </View>

      </View>
    );

  }
  }
  const styles = StyleSheet.create({
    testo:{
      fontSize:30,
      textAlign:'center',
      color:'red'
      
      
    },
    soma:{
      marginTop:50,
      fontSize:30,
      textAlign:'center',
      
    },
    botao:{
      marginTop:100,
      flexDirection:'row',
      alignItems:'center',
      justifyContent:'space-around',
        
    }
      
  });
  export default App;