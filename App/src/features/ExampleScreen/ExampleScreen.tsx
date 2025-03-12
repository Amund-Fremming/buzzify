import { View, Text } from "react-native";

import { styles } from "./exampleScreenStyles";
import SmallButton from "@/src/shared/components/SmallButton/SmallButton";
import { Colors } from "@/src/shared/constants/Colors";
import MediumButton from "@/src/shared/components/MediumButton/MediumButton";
import BigButton from "@/src/shared/components/BigButton/BigButton";
import { useInfoModalProvider } from "@/src/shared/providers/InfoModalProvider";
import { useActionModalProvider } from "@/src/shared/providers/ActionModalProvider";

export default function ExampleScreen() {
  const { toggleInfoModal } = useInfoModalProvider();
  const { toggleActionModal } = useActionModalProvider();

  return (
    <View style={styles.container}>
      <Text style={styles.header}>ExampleScreen</Text>
      <SmallButton
        text="Small"
        color={Colors.Black}
        inverted
        onClick={() => console.log("Small clicked")}
      />
      <MediumButton
        text="Medium"
        color={Colors.Black}
        onClick={() => console.log("Medium clicked")}
        inverted
      />
      <BigButton
        text="Big"
        color={Colors.Black}
        onClick={() => console.log("Big clicked")}
        inverted
      />
      <MediumButton
        text="Info modal"
        color={Colors.Black}
        onClick={() => toggleInfoModal(false, "Info message ...")}
      />
      <MediumButton
        text="Error modal"
        color={Colors.Black}
        onClick={() => toggleInfoModal(true, "Error message ...")}
      />
      <MediumButton
        text="Action modal"
        color={Colors.Black}
        onClick={() =>
          toggleActionModal(
            "Are you sure?",
            () => console.log("No pressed"),
            () => console.log("Yes pressed")
          )
        }
      />
    </View>
  );
}
