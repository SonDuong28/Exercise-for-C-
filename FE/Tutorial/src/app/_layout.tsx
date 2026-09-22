import { View, Text } from 'react-native'
import React from 'react'
import Index from "./index"
import { SafeAreaProvider } from 'react-native-safe-area-context'

export default function _layout() {
  return (
    <SafeAreaProvider>
      <Index />
    </SafeAreaProvider>
  )
} 