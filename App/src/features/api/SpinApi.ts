import {  } from "@/contenttypes";


export const test = async () => {
	try {
		const response = await fetch(`api/Spin/}`, {
			method: "GET",
			headers: {
				"Content-Type": "application/json",
				
			},
			
		});

		if (!response.ok) {
			const errorMessage = await response.json();
			throw new Error(errorMessage);
		}

		
	} catch (error) {
		console.log("Test -", error);
	}
};
