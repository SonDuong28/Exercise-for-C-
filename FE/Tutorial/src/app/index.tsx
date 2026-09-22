import { StyleSheet, Text, View } from "react-native";
import {SafeAreaView } from "react-native-safe-area-context";

export default function App(){
  return (
    <SafeAreaView style={[styles.container, { flexDirection: "column" }]}>
      <View style={styles.header}>
        <View>
        <Text style ={{fontWeight: 'bold'}}>hello</Text>
        </View> 
      </View>
      <View style={styles.body}> </View>
      <View style={styles.footer}> </View>
    </SafeAreaView>
  );
}
const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  header:{
    flex: 1, backgroundColor: "red", borderTopRightRadius: 15 , borderTopLeftRadius: 15

  },

  footer:{
    flex: 1, 
    backgroundColor: "green", 
    borderBottomRightRadius: 15 , 
    borderBottomLeftRadius: 15
  },
  body:{
    flex: 8, 
    backgroundColor: 
    "darkorange"
  }
});
