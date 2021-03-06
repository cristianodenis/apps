import React,{useState,useEffect} from 'react';
import {View,Text,ScrollView,Image,TextInput,
KeyboardAvoidingView,TouchableOpacity,Switch,Alert} from 'react-native';

import { useNavigation } from '@react-navigation/native';
import * as Network from 'expo-network';
import api from '../../services/api';

import styles from './styles';
//COMPONENTES
import Header from '../../Components/Header';
import Footer from '../../Components/Footer';
import typeIcons from '../../utils/typeIcons';
import DateTimeInput from '../../Components/DateTimeInput';

//switch vdd ou false botão de arastar                                 id ja esta aqui

export default function Task(props){

   const navigation = useNavigation();

    const [done,setDone] = useState(false);
    const [type,setType] = useState();
    const [title,setTitle] = useState(props.route.params.title);
    const [date,setDate] = useState();
    const [hour,setHour] = useState();
    const [description,setDescription] = useState(props.route.params.description);
    const [macaddress,setMacaddress] = useState();
    const [load,setLoad] = useState(true);

    const teste = props.route.params.title;
 
    const id = props.route.params.id;
    const icon = props.route.params.icon;
    const dh = date +"T"+ hour;
  
    //pegar o macaddress
    async function getmacaddress(){
      await Network.getIpAddressAsync().then(mac =>{
        setMacaddress(mac);
        setLoad(false);
      })
    }
    /* preferencia consumir dados direto do banco
    async function LoadTask(){
       await api.get(`tarefa/${id}`).then(()=>{
          setLoad(true);
          setDone(response.data.done);
          setTitle(response.data.title);
          setDescription(response.data.description);
          setDate(response.data.when);
          setHour(response.data.when);
       });
    }*/

    async function Excluir(){
      { id != null &&

       await api.delete(`tarefa/${id}`,{
        macaddress: macaddress,
        type: type,
        title: title,
        description: description,
        when: dh,
        })
        .then(()=>{
      
          navigation.navigate('Home');
       })
       .catch(()=>{
           alert('ALGO DEU ERRADO!');
       })

     }

   }
    
    //ao carregar a tela o macaddress carrega tambem
    useEffect(()=>{
      getmacaddress();
    });

    return(
   
            <KeyboardAvoidingView  style={styles.container}>
                <Header showBack={true}/>

                <ScrollView horizontal={true} showsHorizontalScrollIndicator={false} style={{marginTop:10,height:70}}>
                    {
                        typeIcons.map((icon,index) =>(
                            icon != null &&
                          <TouchableOpacity onPress={() => setType(index)}>  
                              <Image source={icon} style={[styles.imageIcon, type && styles.imageIcon && type != index && styles.typeIconInative]}/>
                          </TouchableOpacity>
                        ))
                    }
                </ScrollView>

                <ScrollView style={{width: '100%', marginTop:-5}}>

                <Text style={styles.label}>Título</Text>
                <TextInput style={styles.input} maxLength={30} placeholder="Lembre-me de fazer..." 
                onChangeText={(text) => setTitle(text)}
                value={title}/>

                <Text style={styles.label}>Detalhes</Text>
                <TextInput style={styles.inputarea} maxLength={200} multiline={true} placeholder="Detalhes da atividade..." 
                 onChangeText={(text) => setDescription(text)}
                 value={description}
                 />
                
                <DateTimeInput type={'date'} save={setDate} icon={icon} dt={props.route.params.data} id={id}/>
                <DateTimeInput type={'hour'} save={setHour} icon={icon} hora={props.route.params.hora} id={id}/>

               <View style={styles.inLine}>
                    <View style={styles.inputInline}>
                     <Switch onValueChange={()=> setDone(!done)} value={done} thumbColor={!done ? '#EE6B26': 'green' }/>
                       <Text style={styles.switchLabel}>Concluído</Text>
                    </View>
                    <TouchableOpacity onPress={Excluir}>
                      <Text style={styles.removeLabel}>EXCLUIR</Text>
                    </TouchableOpacity>
                </View> 
                 

                <View style={{marginTop:100}}>
                <Footer icon={'save'} 
                 macaddress={macaddress}
                 type={type} title={title}
                 description={description}
                 data={dh} dt={date}
                 hora={hour}
                 id={id}/>
              </View>

            </ScrollView>
            
            </KeyboardAvoidingView>
                
    );
}